using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using wlc2.Data;
using wlc2.Models;

namespace wlc2.Controllers {

    [Authorize]
    public class HomeController : Controller {
        
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
                
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager) {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            /**
             * If the user is a student, we want to get:
             * - All the student projects;
             * - All the student applications;
             * - All the available project proposals.
             */
            if (User.IsInRole("Student"))
            {
                // Get current user id:
                var loggedUser = await _userManager.GetUserAsync(User);
                var loggedUserId = await _userManager.GetUserIdAsync(loggedUser);

                // Get the student id:
                var studentId = _context.Students.FirstOrDefault(s => s.UserId == loggedUserId)?.Id;

                // Find student by id on table "application" and include a list of application proposals:
                var student = _context.Students
                    .Include(s => s.Applications)
                    .ThenInclude(a => a.ApplicationProposals)
                    .FirstOrDefault(s => s.Id == studentId);

                // If student does not exists:
                if (student == null)
                {
                    return NotFound();
                }

                // Get the proposals id's associated to application proposals:
                var proposalsIdList = student.Applications
                    .SelectMany(a => a.ApplicationProposals.Select(ap => ap.ProposalFK))
                    .ToList();

                // Get the complete data of the proposals with the list of proposals id's 'proposaslIdList':
                var proposals = _context.Proposals
                    .Where(p => proposalsIdList.Contains(p.Id))
                    .Include(p => p.Advisors)
                    .OrderBy(p => p.ApplicationProposals.FirstOrDefault().Order)
                    .ToList();

                // Get all proposals that are approved:
                var approvedProposals = _context.Proposals
                    .Include(p => p.Course)
                    .Include(p => p.Institution)
                    .Include(p => p.Advisors)
                    .Where(p => p.ProposalStatus == ProposalStatus.approved)
                    .ToList();

                // Get all applications:
                var applications = _context.Applications
                    .Include(a => a.AcademicYear)
                    .Include(a => a.Course)
                    .Where(a => a.Students.Any(s => s.Id == studentId))
                    .ToList();

                // Get all projects:
                var projects = _context.Projects
                    .Where(p => p.Students.Any(s => s.Id == studentId))
                    .ToList();

                // Get actual academic year:
                //var academicYear = _context.AcademicYears.LastOrDefault();

                // Prepare a view model to send data to the view:
                var viewModel = new ViewModel
                {
                    //AcademicYear = academicYear,
                    Proposals = proposals,
                    Applications = applications,
                    ApprovedProposals = approvedProposals,
                    Projects = projects
                };

                return View(viewModel);
            }

            /**
             * If the user is advisor, show:
             * - all associated projects;
             * - all proposals;
             * 
             * If is an admin, he will be allowed to:
             * - approve proposals.
             */

            // my projects, my proposals, my courses proposals, projects where i am jury
            if (User.IsInRole("Advisor"))
            {
                // Get current user id:
                var loggedUser = await _userManager.GetUserAsync(User);
                var loggedUserId = await _userManager.GetUserIdAsync(loggedUser);

                // Get the advisor id:
                var advisorId = _context.Advisors.FirstOrDefault(s => s.UserId == loggedUserId)?.Id;

                // Get the advisor data:
                var advisor = _context.Advisors
                    .FirstOrDefault(a => a.Id == advisorId);

                // Check if the advisor exists:
                if (advisor == null)
                {
                    return NotFound();
                }

                // Get all proposals that are approved:
                var approvedProposals = _context.Proposals
                    .Include(p => p.Course)
                    .Include(p => p.Institution)
                    .Include(p => p.Advisors)
                    .Where(p => p.ProposalStatus == ProposalStatus.approved)
                    .ToList();

                // Verify admin status for the advisor:
                var courseAdvisors = _context.CourseAdvisors
                    .Where(ca => ca.AdvisorFK == advisorId)
                    .ToList();
                bool isAdmin = courseAdvisors.Any(ca => ca.IsAdmin);

                var myProposals = _context.Proposals.ToList();

                var relatedApplications = _context.Applications.ToList();

                Course courseOfFirstRelatedProposal = null;
                // Get all my proposals and the status:
                if (isAdmin)
                {
                    myProposals = _context.Proposals
                        .Include(p => p.Course)
                        .Include(p => p.Institution)
                        .Include(p => p.Advisors)
                        .Where(p => p.ProposalStatus == ProposalStatus.draft)
                        .ToList();

                    // Get applications from related courses:
                    var advisorCourses = _context.CourseAdvisors
                        .Where(ca => ca.AdvisorFK == advisorId)
                        .Select(ca => ca.CourseFK)
                        .ToList();
                    relatedApplications = _context.Applications
                        .Where(app => app.ApplicationProposals.Any(ap => advisorCourses.Contains(ap.Proposal.CourseFK)))
                        .Include(app => app.ApplicationProposals)
                        .Include(app => app.Students)
                        .ToList();

                    // Get the first related application:
                    var firstRelatedApplication = relatedApplications.FirstOrDefault();

                    if (firstRelatedApplication != null)
                    {
                        // Get the first proposal related to the application:
                        var firstRelatedProposal = firstRelatedApplication.ApplicationProposals.FirstOrDefault()?.Proposal;
                        firstRelatedProposal = _context.Proposals
                            .Where(p => p.Equals(firstRelatedProposal))
                            .Include(p => p.Course)
                            .FirstOrDefault();

                        if (firstRelatedProposal != null)
                        {
                            // Get the course of the first related proposal:
                            courseOfFirstRelatedProposal = firstRelatedProposal.Course;
                        }
                    }
                } else
                {
                    myProposals = _context.Proposals
                        .Include(p => p.Course)
                        .Include(p => p.Institution)
                        .Include(p => p.Advisors)
                        .Where(p => p.Advisors.Any(a => a.Id == advisorId) && p.ProposalStatus == ProposalStatus.draft)
                        .ToList();
                }

                // Get actual academic year:
                var academicYear = _context.AcademicYears
                    .Where(ay => ay.Current == true)
                    .First();

                // Get all projects:
                var projects = _context.Projects
                    .Include(p => p.Course)
                    .Include(p => p.Students)
                    .Include(p => p.Advisors)
                    .Where(p => p.Advisors.Any(a => a.Id == advisorId))
                    .ToList();

                // Prepare a view model to send data to the view:
                var viewModel = new ViewModel
                {
                    AcademicYear = academicYear,
                    Proposals = myProposals,
                    ApprovedProposals = approvedProposals,
                    IsCourseAdmin = isAdmin,
                    Applications = relatedApplications,
                    Course = courseOfFirstRelatedProposal,
                    Projects = projects
                };
                
                return View(viewModel);
            }

            return View();
        }



        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}