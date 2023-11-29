using System;
using System.Collections.Generic;
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
    public class IdentificationTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IdentificationTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: IdentificationTypes
        public async Task<IActionResult> Index()
        {
              return View(await _context.IdentificationTypes.ToListAsync());
        }

        // GET: IdentificationTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.IdentificationTypes == null)
            {
                return NotFound();
            }

            var identificationType = await _context.IdentificationTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (identificationType == null)
            {
                return NotFound();
            }

            return View(identificationType);
        }

        // GET: IdentificationTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IdentificationTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code")] IdentificationType identificationType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(identificationType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(identificationType);
        }

        // GET: IdentificationTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.IdentificationTypes == null)
            {
                return NotFound();
            }

            var identificationType = await _context.IdentificationTypes.FindAsync(id);
            if (identificationType == null)
            {
                return NotFound();
            }
            return View(identificationType);
        }

        // POST: IdentificationTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code")] IdentificationType identificationType)
        {
            if (id != identificationType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(identificationType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IdentificationTypeExists(identificationType.Id))
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
            return View(identificationType);
        }

        // GET: IdentificationTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.IdentificationTypes == null)
            {
                return NotFound();
            }

            var identificationType = await _context.IdentificationTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (identificationType == null)
            {
                return NotFound();
            }

            return View(identificationType);
        }

        // POST: IdentificationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.IdentificationTypes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.IdentificationTypes'  is null.");
            }
            var identificationType = await _context.IdentificationTypes.FindAsync(id);
            if (identificationType != null)
            {
                _context.IdentificationTypes.Remove(identificationType);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IdentificationTypeExists(int id)
        {
          return _context.IdentificationTypes.Any(e => e.Id == id);
        }
    }
}
