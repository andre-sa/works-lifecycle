using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using wlc2.Data;
using wlc2.Models;
using static System.Net.Mime.MediaTypeNames;

namespace wlc2.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProjectsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Projects.Include(p => p.AcademicYear).Include(p => p.AccessType).Include(p => p.Language).Include(p => p.License);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.AcademicYear)
                .Include(p => p.AccessType)
                .Include(p => p.Language)
                .Include(p => p.License)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name");
            ViewData["AccessTypeFK"] = new SelectList(_context.AccessTypes, "Id", "Id");
            ViewData["LanguageFK"] = new SelectList(_context.Languages, "Id", "Alpha2Code");
            ViewData["LicenseFK"] = new SelectList(_context.Licenses, "Id", "Id");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,AbstractPT,AbstractEN,KeywordsPT,KeywordsEN,ProjectStatus,Grade,AcademicYearFK,LanguageFK,AccessTypeFK,LicenseFK")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AcademicYearFK"] = new SelectList(_context.AcademicYears, "Id", "Name", project.AcademicYearFK);
            ViewData["AccessTypeFK"] = new SelectList(_context.AccessTypes, "Id", "Id", project.AccessTypeFK);
            ViewData["LanguageFK"] = new SelectList(_context.Languages, "Id", "Alpha2Code", project.LanguageFK);
            ViewData["LicenseFK"] = new SelectList(_context.Licenses, "Id", "Id", project.LicenseFK);
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            // Get the project:
            var project = await _context.Projects
                .Include(p => p.AcademicYear)
                .Include(p => p.AccessType)
                .Include(p => p.Advisors)
                .Include(p => p.Language)
                .Include(p => p.License)
                .Include(p => p.Students)
                .FirstOrDefaultAsync(p => p.Id == id);
            
            if (project == null)
            {
                return NotFound();
            }

            // Get a list of academic years:
            var languages = await _context.Languages.ToListAsync();

            // Get a list of licenses:
            var licenses = await _context.Licenses.ToListAsync();

            // Get a list of access types:
            var accessTypes = await _context.AccessTypes.ToListAsync();

            var viewModel = new ProjectViewModel
            {
                Project = project,
                Languages = languages,
                Licenses = licenses,
                AccessTypes = accessTypes
            };

            return View(viewModel);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int language, int license, int accessType, string keywordsPT, string keywordsEN, string abstractPT, string abstractEN, IFormFile projectReport)
        {

            var project = _context.Projects.Where(p => p.Id == id).FirstOrDefault();

            if (project == null)
            {
                return NotFound();
            }

            project.LanguageFK = language;
            project.LicenseFK = license;
            project.AccessTypeFK = accessType;
            project.KeywordsPT = keywordsPT;
            project.KeywordsEN = keywordsEN;
            project.AbstractPT = abstractPT;
            project.AbstractEN = abstractEN;

            if (projectReport != null)
            {
                try
                {
                    // Remove, if exists, the old report:
                    string oldReportName = project.ProjectReport;
                    string reportPath = Path.Combine(_webHostEnvironment.WebRootPath, "Reports", oldReportName);

                    if (oldReportName != null && System.IO.File.Exists(reportPath))
                    {
                        System.IO.File.Delete(reportPath);
                    }
                } catch { }
                

                // Name the file:
                string fileName = "RELATORIO_PROJETO_" + project.Id + ".pdf";
                project.ProjectReport = fileName;

                // Saves the file:
                string localFileName = _webHostEnvironment.WebRootPath;
                localFileName = Path.Combine(localFileName, "Reports");
                if (!Directory.Exists(localFileName))
                {
                    Directory.CreateDirectory(localFileName);
                }
                string reportFileName = Path.Combine(localFileName, fileName);
                using var stream = new FileStream(reportFileName, FileMode.Create);
                await projectReport.CopyToAsync(stream);
            }

            _context.Update(project);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Projects == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.AcademicYear)
                .Include(p => p.AccessType)
                .Include(p => p.Language)
                .Include(p => p.License)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Projects == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Projects'  is null.");
            }
            var project = await _context.Projects.FindAsync(id);
            if (project != null)
            {
                _context.Projects.Remove(project);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
          return _context.Projects.Any(e => e.Id == id);
        }
    }
}
