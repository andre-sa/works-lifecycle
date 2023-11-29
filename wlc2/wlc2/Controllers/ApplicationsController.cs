using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Packaging;
using wlc2.Data;
using wlc2.Models;

namespace wlc2.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;


        public ApplicationsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Applications
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Applications.Include(a => a.AcademicYear);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Applications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Applications == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .Include(a => a.AcademicYear)
                .Include(a => a.Course)
                .Include(a => a.Students)
                .Include(a => a.ApplicationProposals)
                .ThenInclude(ap => ap.Proposal)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (application == null)
            {
                return NotFound();
            }


            // Get the current academic year:
            var academicYear = _context.AcademicYears
                    .Where(ay => ay.Current == true)
                    .First();

            var viewModel = new ApplicationViewModel
            {
                Application = application,
                AcademicYear = academicYear
            };

            return View(viewModel);
        }

        // GET: Applications/Create
        public async Task<IActionResult> Create()
        {
            // Get user Id:
            var loggedUser = await _userManager.GetUserAsync(User);
            var loggedUserId = await _userManager.GetUserIdAsync(loggedUser);

            // Get student:
            var student = _context.Students.FirstOrDefault(s => s.UserId == loggedUserId);

            // Get student courses:
            var studentEnrollments = _context.Enrollments
                .Where(e => e.StudentFK == student.Id)
                .ToList();

            // Get id's of the student courses:
            var coursesId = studentEnrollments.Select(e => e.CourseFK).ToList();

            // Get all approved proposals associated to those courses:
            var approvedProposals = _context.Proposals
                .Where(p => p.ProposalStatus == ProposalStatus.approved && coursesId.Contains(p.CourseFK))
                .ToList();

            // Get all associated courses to this student:
            var associatedCourses = _context.Courses
                .Where(c => coursesId.Contains(c.Id))
                .ToList();

            ViewData["ApprovedProposalsFK"] = new SelectList(approvedProposals, "Id", "Title");
            ViewData["CourseFK"] = new SelectList(associatedCourses, "Id", "Name", "Degree");

            var courses = _context.Courses.ToList();
            var courseDictionary = courses.ToDictionary(c => c.Id, c => c.Degree);
            ViewBag.CourseDegrees = courseDictionary;

            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SubmittedDate,ApplicationStatus,AcademicYearFK, CourseFK")] Application application, string studentsList,
            int preference1,
            int preference2,
            int preference3,
            int preference4,
            int preference5,
            int preference6)
        {

            // Access to preferences using the Request object:
            List<int> preferences = new List<int>
            {
                int.Parse(Request.Form["preference1"]),
                int.Parse(Request.Form["preference2"]),
                int.Parse(Request.Form["preference3"]),
                int.Parse(Request.Form["preference4"]),
                int.Parse(Request.Form["preference5"]),
                int.Parse(Request.Form["preference6"])
            };

            if (ModelState.IsValid)
            {
                // Populate application data:
                application.ApplicationStatus = ApplicationStatus.submitted;
                application.SubmittedDate = DateTime.Now;
                var lastAcademicYear = _context.AcademicYears.FirstOrDefault(ay => ay.Current == true);

                application.AcademicYearFK = lastAcademicYear.Id;
                
                _context.Add(application);
                await _context.SaveChangesAsync();
                // Get a list of student id's from the json format:
                List<int> studentsIdList = JsonConvert.DeserializeObject<List<int>>(studentsList);

                // Get user Id:
                var loggedUser = await _userManager.GetUserAsync(User);
                var loggedUserId = await _userManager.GetUserIdAsync(loggedUser);

                // Add actual student:
                var studentUser = _context.Students.FirstOrDefault(s => s.UserId == loggedUserId);
                application.Students.Add(studentUser);

                // Associate the students to the application:
                if (studentsList != "[]" || studentsList != null)
                {
                    // For each student we will create an automatic application:
                    foreach (var studentId in studentsIdList)
                    {
                        // Get the student:
                        var student = _context.Students.FirstOrDefault(s => s.Id == studentId);

                        // Add student to the application:
                        application.Students.Add(student);
                    }

                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }

                /* Create the ApplicationProposals */
                for (int i = 0; i <= 5; i++)
                {
                    int preference = preferences[i];
                    
                    if (preference != 0)
                    {
                        ApplicationProposal applicationProposal = new ApplicationProposal();
                        applicationProposal.ProposalFK = preference;
                        applicationProposal.ApplicationFK = application.Id;
                        applicationProposal.Order = i + 1;
                        _context.Add(applicationProposal);
                        await _context.SaveChangesAsync();

                        application.ApplicationProposals.Add(applicationProposal);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", application.AcademicYearFK);
            return View(application);
        }

        // GET: Applications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Applications == null)
            {
                return NotFound();
            }

            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", application.AcademicYearFK);
            return View(application);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SubmittedDate,ApplicationStatus,AcademicYearFK")] Application application)
        {
            if (id != application.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(application);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationExists(application.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", application.AcademicYearFK);
            return View(application);
        }

        // GET: Applications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Applications == null)
            {
                return NotFound();
            }

            var application = await _context.Applications
                .Include(a => a.AcademicYear)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (application == null)
            {
                return NotFound();
            }

            return View(application);
        }

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Applications == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Applications'  is null.");
            }
            var application = await _context.Applications.FindAsync(id);
            if (application != null)
            {
                _context.Applications.Remove(application);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Gets a list of students.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetStudentsList()
        {
            // Gets a list of students associated with the courseId using join:
            var students = _context.Students
                .ToList();

            // Convert students variable (is a DbSet) to a string:
            string json = JsonConvert.SerializeObject(students);

            // Creates a list of students of type list in json format:
            List<Student> studentsList = JsonConvert.DeserializeObject<List<Student>>(json);

            return Json(studentsList);
        }

        /// <summary>
        /// Automatically approve an application.
        /// </summary>
        /// <param name="students"></param>
        /// <param name="proposals"></param>
        /// <returns></returns>
        public async Task<IActionResult> ApproveApplication(string students, string proposals)
        {
            // Convert JSON to Lists:
            List<Student> studentsList = JsonConvert.DeserializeObject<List<Student>>(students);
            List<ApplicationProposal> proposalsList = JsonConvert.DeserializeObject<List<ApplicationProposal>>(proposals);
            
            // Data validation:
            if (studentsList != null && proposalsList != null && studentsList.Any() && proposalsList.Any())
            {
                // For students (get all of them)...
                List<int> studentIds = new List<int>();
                foreach (var tempStudent in studentsList)
                {
                    var student = _context.Students.FirstOrDefault(s => s.Email == tempStudent.Email);
                    var studentId = student.Id;
                    studentIds.Add(studentId);
                }
                // For proposals (get the proposal that was not assigned yet)...
                List<int> proposalIds = new List<int>();
                foreach (var tempProposal in proposalsList)
                {
                    var ap = _context.ApplicationProposals.FirstOrDefault(ap => ap.Id == tempProposal.Id);
                    var proposalId = ap.ProposalFK;
                    proposalIds.Add(proposalId);
                }
                int proposalToAssign = -1;
                foreach (var proposalId in proposalIds)
                {
                    var currentProposal = _context.Proposals.FirstOrDefault(p => p.Id == proposalId);
                    if (currentProposal.ProposalStatus != ProposalStatus.assigned)
                    {
                        proposalToAssign = currentProposal.Id;
                        Proposal proposal = _context.Proposals.FirstOrDefault(p => p.Id.Equals(proposalToAssign));
                        proposal.ProposalStatus = ProposalStatus.assigned;
                        _context.Update(proposal);
                        await _context.SaveChangesAsync();
                        break;
                    }
                }

                // Creates the project and associate the students:
                if (proposalToAssign != -1)
                {
                    // Get the proposal:
                    Proposal proposal = _context.Proposals
                        .Include(p => p.Advisors)
                        .FirstOrDefault(p => p.Id.Equals(proposalToAssign));

                    // Create the project and pre-populate it:
                    Project project = new Project
                    {
                        Title = proposal.Title,
                        ProjectStatus = ProjectStatus.ongoing,
                        AcademicYearFK = proposal.AcademicYearFK,
                        AccessTypeFK = 1,
                        LanguageFK = 1,
                        LicenseFK = 1,
                        CourseFK = proposal.CourseFK
                    };

                    // Retrieve students by IDs and add them to the project:
                    var studentsToAdd = _context.Students.Where(s => studentIds.Contains(s.Id));
                    foreach (var student in studentsToAdd)
                    {
                        project.Students.Add(student);
                    }

                    // Add advisors direcly from the proposal's advisors collection:
                    foreach (var advisor in proposal.Advisors)
                    {
                        project.Advisors.Add(advisor);
                    }

                    try
                    {
                        // Add the project to the context and save changes:
                        _context.Add(project);
                        await _context.SaveChangesAsync();
                    } catch (Exception ex)
                    {
                        Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");
                        Console.WriteLine($"StackTrace: {ex.StackTrace}");
                    }
                    
                }
            } else
            {
                // Error:
                return BadRequest("Invalid data or no data available.");
            }

            return RedirectToAction("Index");
        }

        private bool ApplicationExists(int id)
        {
          return _context.Applications.Any(e => e.Id == id);
        }
    }
}
