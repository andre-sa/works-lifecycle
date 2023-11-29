using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using wlc2.Data;
using wlc2.Models;
using static System.Net.Mime.MediaTypeNames;

namespace wlc2.Controllers
{
    public class ProposalsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ProposalsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Proposals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Proposals.Include(p => p.AcademicYear).Include(p => p.Course).Include(p => p.Institution);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Proposals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Proposals == null)
            {
                return NotFound();
            }

            var proposal = await _context.Proposals
                .Include(p => p.AcademicYear)
                .Include(p => p.Course)
                .Include(p => p.Institution)
                .Include(p => p.Advisors)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposal == null)
            {
                return NotFound();
            }

            return View(proposal);
        }

        // GET: Proposals/Create
        [Authorize(Roles = "Admin, Advisor")]
        public async Task<IActionResult> Create()
        {
            if (User.IsInRole("Admin"))
            {
                ViewData["CourseFK"] = new SelectList(_context.Courses, "Id", "Name", "Degree");
            }
            
            if (User.IsInRole("Advisor"))
            {
                // Get user Id.
                var loggedUser = await _userManager.GetUserAsync(User);
                var loggedUserId = await _userManager.GetUserIdAsync(loggedUser);

                // Get advisor Id.
                var advisorId = _context.Advisors.FirstOrDefault(a => a.UserId == loggedUserId)?.Id;
                
                // Get courses associated to this user.
                var associatedCourses = _context.CourseAdvisors
                    .Where(ca => ca.AdvisorFK == advisorId)
                    .Select(ca => ca.CourseFK)
                    .ToList();

                //Creates ViewData
                ViewData["CourseFK"] = new SelectList(_context.Courses.Where(c => associatedCourses.Contains(c.Id)), "Id", "Name", "Degree");
            }

            var courses = _context.Courses.ToList();
            var courseDictionary = courses.ToDictionary(c => c.Id, c => c.Degree);
            ViewBag.CourseDegrees = courseDictionary;


            //ViewData["CourseFK"] = new SelectList(_context.Courses, "Id", "Name");
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name");
            ViewData["InstitutionFK"] = new SelectList(_context.Institutions, "Id", "Name");
            return View();
        }

        // POST: Proposals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,ProposalStatus,CourseFK,InstitutionFK,AcademicYearFK")] Proposal proposal, string studentsList, string advisorsList)
        {
            if (ModelState.IsValid)
            {
                // Add proposal to database:
                _context.Add(proposal);
                await _context.SaveChangesAsync();

                // Associate the selected students to the proposal:
                if (studentsList != "[]")
                {
                    // Get a list of student id's from the json format:
                    List<int> studentsIdList = JsonConvert.DeserializeObject<List<int>>(studentsList);

                    // Creates an application and an application proposal:
                    Models.Application application = new Models.Application();
                    ApplicationProposal applicationProposal = new ApplicationProposal();
                    
                    // Populate application data:
                    application.ApplicationStatus = ApplicationStatus.assigned;
                    application.AcademicYearFK = proposal.AcademicYearFK;
                    application.SubmittedDate = DateTime.Now;
                    application.CourseFK = proposal.CourseFK;

                    // For each student we will create an automatic application:
                    foreach (var studentId in studentsIdList)
                    {
                        // Get the student:
                        var student = _context.Students.FirstOrDefault(s => s.Id == studentId);

                        // Add student to the application:
                        application.Students.Add(student);
                    }

                    // Add application to database:
                    _context.Add(application);
                    await _context.SaveChangesAsync();

                    // Populate application proposal data:
                    applicationProposal.ApplicationFK = application.Id;
                    applicationProposal.Order = 1;
                    applicationProposal.ProposalFK = proposal.Id;

                    // Add application proposal to database:
                    _context.Add(applicationProposal);
                    await _context.SaveChangesAsync();
                }

                /* Now, we will add advisors to the proposal. */

                /* Automacally adds the logged advisor who creates the proposal to the proposal: */
                
                // Get user Id.
                var loggedUser = await _userManager.GetUserAsync(User);
                var loggedUserId = await _userManager.GetUserIdAsync(loggedUser);

                // Get creator advisor.
                var advisorId = _context.Advisors.FirstOrDefault(a => a.UserId == loggedUserId)?.Id;
                var advisor = _context.Advisors.FirstOrDefault(a => a.Id == advisorId);

                // Add this advisorId:
                proposal.Advisors.Add(advisor);
                await _context.SaveChangesAsync();

                if (advisorsList != "[]")
                {
                    // Get a list of student id's from the json format:
                    List<int> advisorsIdList = JsonConvert.DeserializeObject<List<int>>(advisorsList);

                    // For each advisor we will add him to the proposal:
                    foreach (var advisorIdInList in advisorsIdList)
                    {
                        // Get the advisor:
                        advisor = _context.Advisors.FirstOrDefault(a => a.Id == advisorIdInList);

                        // Add student to the application:
                        proposal.Advisors.Add(advisor);
                        await _context.SaveChangesAsync();
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", proposal.AcademicYearFK);
            ViewData["CourseFK"] = new SelectList(_context.Courses, "Id", "Code", proposal.CourseFK);
            ViewData["InstitutionFK"] = new SelectList(_context.Institutions, "Id", "Id", proposal.InstitutionFK);
            return View(proposal);
        }


        // GET: Proposals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Proposals == null)
            {
                return NotFound();
            }

            var proposal = await _context.Proposals.FindAsync(id);
            if (proposal == null)
            {
                return NotFound();
            }
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", proposal.AcademicYearFK);
            ViewData["CourseFK"] = new SelectList(_context.Courses, "Id", "Code", proposal.CourseFK);
            ViewData["InstitutionFK"] = new SelectList(_context.Institutions, "Id", "Id", proposal.InstitutionFK);
            return View(proposal);
        }

        // POST: Proposals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,ProposalStatus,CourseFK,InstitutionFK,AcademicYearFK")] Proposal proposal)
        {
            if (id != proposal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proposal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProposalExists(proposal.Id))
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
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", proposal.AcademicYearFK);
            ViewData["CourseFK"] = new SelectList(_context.Courses, "Id", "Code", proposal.CourseFK);
            ViewData["InstitutionFK"] = new SelectList(_context.Institutions, "Id", "Id", proposal.InstitutionFK);
            return View(proposal);
        }

        // GET: Proposals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Proposals == null)
            {
                return NotFound();
            }

            var proposal = await _context.Proposals
                .Include(p => p.AcademicYear)
                .Include(p => p.Course)
                .Include(p => p.Institution)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proposal == null)
            {
                return NotFound();
            }

            return View(proposal);
        }

        // POST: Proposals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Proposals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Proposals'  is null.");
            }
            var proposal = await _context.Proposals.FindAsync(id);
            if (proposal != null)
            {
                _context.Proposals.Remove(proposal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Gets a list of students associated to a course.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetStudentsList(int courseId)
        {
            // Gets a list of students associated with the courseId using join:
            var students = _context.Students
                .Join(_context.Enrollments,
                      student => student.Id,                // PK for table students.
                      enrollment => enrollment.StudentFK,   // FK for students on table Enrollments.
                      (student, enrollment) => new { Student = student, Enrollment = enrollment })
                .Where(se => se.Enrollment.CourseFK == courseId)
                .Select(se => se.Student)
                .ToList();

            // Convert students variable (is a DbSet) to a string:
            string json = JsonConvert.SerializeObject(students);

            // Creates a list of students of type list in json format:
            List<Student> studentsList = JsonConvert.DeserializeObject<List<Student>>(json);

            return Json(studentsList);
        }

        /// <summary>
        /// Gets a list of advisors associated to a course.
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAdvisorsList(int courseId)
        {
            // Gets a list of advisors associated with the courseId using join:
            var advisors = _context.Advisors
                .Join(_context.CourseAdvisors,
                      advisor => advisor.Id,        // PK for table advisors.
                      ca => ca.AdvisorFK,           // FK for advisor on table CourseAdvisors.
                      (advisor, ca) => new { Advisor = advisor, CourseAdvisors = ca })
                .Where(se => se.CourseAdvisors.CourseFK == courseId)
                .Select(se => se.Advisor)
                .ToList();

            // Convert advisor variable (is a DbSet) to a string:
            string json = JsonConvert.SerializeObject(advisors);

            // Creates a list of advisors of type list in json format:
            List<Advisor> advisorsList = JsonConvert.DeserializeObject<List<Advisor>>(json);

            return Json(advisorsList);
        }

        // POST: Proposals/SetApproved/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetApproved(int id)
        {
            var proposal = await _context.Proposals.FindAsync(id);

            if (proposal == null)
            {
                return NotFound();
            }

            proposal.ProposalStatus = ProposalStatus.approved;
            _context.Update(proposal);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        private bool ProposalExists(int id)
        {
          return _context.Proposals.Any(e => e.Id == id);
        }
    }
}
