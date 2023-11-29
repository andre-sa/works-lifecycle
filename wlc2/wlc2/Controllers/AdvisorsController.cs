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
    public class AdvisorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdvisorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Advisors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Advisors.Include(a => a.IdentificationType).Include(a => a.Nationality);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Advisors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Advisors == null)
            {
                return NotFound();
            }

            var advisor = await _context.Advisors
                .Include(a => a.IdentificationType)
                .Include(a => a.Nationality)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advisor == null)
            {
                return NotFound();
            }

            return View(advisor);
        }

        // GET: Advisors/Create
        public IActionResult Create()
        {
            ViewData["IdentificationTypeFK"] = new SelectList(_context.IdentificationTypes, "Id", "Code");
            ViewData["NationalityFK"] = new SelectList(_context.Nationalities, "Id", "Id");
            return View();
        }

        // POST: Advisors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("External,PhD,Specialist,Id,UserId,Name,Email,IdentificationNumber,ORCID,IdentificationTypeFK,NationalityFK")] Advisor advisor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(advisor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentificationTypeFK"] = new SelectList(_context.IdentificationTypes, "Id", "Code", advisor.IdentificationTypeFK);
            ViewData["NationalityFK"] = new SelectList(_context.Nationalities, "Id", "Id", advisor.NationalityFK);
            return View(advisor);
        }

        // GET: Advisors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Advisors == null)
            {
                return NotFound();
            }

            var advisor = await _context.Advisors.FindAsync(id);
            if (advisor == null)
            {
                return NotFound();
            }
            ViewData["IdentificationTypeFK"] = new SelectList(_context.IdentificationTypes, "Id", "Code", advisor.IdentificationTypeFK);
            ViewData["NationalityFK"] = new SelectList(_context.Nationalities, "Id", "Id", advisor.NationalityFK);
            return View(advisor);
        }

        // POST: Advisors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("External,PhD,Specialist,Id,UserId,Name,Email,IdentificationNumber,ORCID,IdentificationTypeFK,NationalityFK")] Advisor advisor)
        {
            if (id != advisor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(advisor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdvisorExists(advisor.Id))
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
            ViewData["IdentificationTypeFK"] = new SelectList(_context.IdentificationTypes, "Id", "Code", advisor.IdentificationTypeFK);
            ViewData["NationalityFK"] = new SelectList(_context.Nationalities, "Id", "Id", advisor.NationalityFK);
            return View(advisor);
        }

        // GET: Advisors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Advisors == null)
            {
                return NotFound();
            }

            var advisor = await _context.Advisors
                .Include(a => a.IdentificationType)
                .Include(a => a.Nationality)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (advisor == null)
            {
                return NotFound();
            }

            return View(advisor);
        }

        // POST: Advisors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Advisors == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Advisors'  is null.");
            }
            var advisor = await _context.Advisors.FindAsync(id);
            if (advisor != null)
            {
                _context.Advisors.Remove(advisor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdvisorExists(int id)
        {
          return _context.Advisors.Any(e => e.Id == id);
        }
    }
}
