﻿using System;
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
    public class LicensesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LicensesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Licenses
        public async Task<IActionResult> Index()
        {
              return View(await _context.Licenses.ToListAsync());
        }

        // GET: Licenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Licenses == null)
            {
                return NotFound();
            }

            var license = await _context.Licenses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (license == null)
            {
                return NotFound();
            }

            return View(license);
        }

        // GET: Licenses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Licenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,RcaapCode")] License license)
        {
            if (ModelState.IsValid)
            {
                _context.Add(license);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(license);
        }

        // GET: Licenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Licenses == null)
            {
                return NotFound();
            }

            var license = await _context.Licenses.FindAsync(id);
            if (license == null)
            {
                return NotFound();
            }
            return View(license);
        }

        // POST: Licenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,RcaapCode")] License license)
        {
            if (id != license.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(license);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicenseExists(license.Id))
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
            return View(license);
        }

        // GET: Licenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Licenses == null)
            {
                return NotFound();
            }

            var license = await _context.Licenses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (license == null)
            {
                return NotFound();
            }

            return View(license);
        }

        // POST: Licenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Licenses == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Licenses'  is null.");
            }
            var license = await _context.Licenses.FindAsync(id);
            if (license != null)
            {
                _context.Licenses.Remove(license);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicenseExists(int id)
        {
          return _context.Licenses.Any(e => e.Id == id);
        }
    }
}
