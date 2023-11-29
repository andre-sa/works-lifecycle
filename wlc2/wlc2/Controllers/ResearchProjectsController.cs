using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using wlc2.Data;
using wlc2.Models;

namespace wlc2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ResearchProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResearchProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ResearchProjects
        public async Task<IActionResult> Index()
        {
              return View(await _context.ResearchProjects.ToListAsync());
        }

        // GET: ResearchProjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ResearchProjects == null)
            {
                return NotFound();
            }

            var researchProject = await _context.ResearchProjects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (researchProject == null)
            {
                return NotFound();
            }

            return View(researchProject);
        }

        // GET: ResearchProjects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResearchProjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Reference")] ResearchProject researchProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(researchProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(researchProject);
        }

        // GET: ResearchProjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ResearchProjects == null)
            {
                return NotFound();
            }

            var researchProject = await _context.ResearchProjects.FindAsync(id);
            if (researchProject == null)
            {
                return NotFound();
            }
            return View(researchProject);
        }

        // POST: ResearchProjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Reference")] ResearchProject researchProject)
        {
            if (id != researchProject.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(researchProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResearchProjectExists(researchProject.Id))
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
            return View(researchProject);
        }

        // GET: ResearchProjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ResearchProjects == null)
            {
                return NotFound();
            }

            var researchProject = await _context.ResearchProjects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (researchProject == null)
            {
                return NotFound();
            }

            return View(researchProject);
        }

        // POST: ResearchProjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ResearchProjects == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ResearchProjects'  is null.");
            }
            var researchProject = await _context.ResearchProjects.FindAsync(id);
            if (researchProject != null)
            {
                _context.ResearchProjects.Remove(researchProject);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResearchProjectExists(int id)
        {
          return _context.ResearchProjects.Any(e => e.Id == id);
        }
    }
}
