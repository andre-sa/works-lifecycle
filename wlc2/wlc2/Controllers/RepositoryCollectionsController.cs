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
    public class RepositoryCollectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RepositoryCollectionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RepositoryCollections
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RepositoryCollections.Include(r => r.OrganicUnit);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RepositoryCollections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RepositoryCollections == null)
            {
                return NotFound();
            }

            var repositoryCollection = await _context.RepositoryCollections
                .Include(r => r.OrganicUnit)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (repositoryCollection == null)
            {
                return NotFound();
            }

            return View(repositoryCollection);
        }

        // GET: RepositoryCollections/Create
        public IActionResult Create()
        {
            ViewData["OrganicUnitFK"] = new SelectList(_context.OrganicUnits, "Id", "Id");
            return View();
        }

        // POST: RepositoryCollections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,OrganicUnitFK")] RepositoryCollection repositoryCollection)
        {
            if (ModelState.IsValid)
            {
                _context.Add(repositoryCollection);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrganicUnitFK"] = new SelectList(_context.OrganicUnits, "Id", "Id", repositoryCollection.OrganicUnitFK);
            return View(repositoryCollection);
        }

        // GET: RepositoryCollections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RepositoryCollections == null)
            {
                return NotFound();
            }

            var repositoryCollection = await _context.RepositoryCollections.FindAsync(id);
            if (repositoryCollection == null)
            {
                return NotFound();
            }
            ViewData["OrganicUnitFK"] = new SelectList(_context.OrganicUnits, "Id", "Id", repositoryCollection.OrganicUnitFK);
            return View(repositoryCollection);
        }

        // POST: RepositoryCollections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,OrganicUnitFK")] RepositoryCollection repositoryCollection)
        {
            if (id != repositoryCollection.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(repositoryCollection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepositoryCollectionExists(repositoryCollection.Id))
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
            ViewData["OrganicUnitFK"] = new SelectList(_context.OrganicUnits, "Id", "Id", repositoryCollection.OrganicUnitFK);
            return View(repositoryCollection);
        }

        // GET: RepositoryCollections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RepositoryCollections == null)
            {
                return NotFound();
            }

            var repositoryCollection = await _context.RepositoryCollections
                .Include(r => r.OrganicUnit)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (repositoryCollection == null)
            {
                return NotFound();
            }

            return View(repositoryCollection);
        }

        // POST: RepositoryCollections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RepositoryCollections == null)
            {
                return Problem("Entity set 'ApplicationDbContext.RepositoryCollections'  is null.");
            }
            var repositoryCollection = await _context.RepositoryCollections.FindAsync(id);
            if (repositoryCollection != null)
            {
                _context.RepositoryCollections.Remove(repositoryCollection);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepositoryCollectionExists(int id)
        {
          return _context.RepositoryCollections.Any(e => e.Id == id);
        }
    }
}
