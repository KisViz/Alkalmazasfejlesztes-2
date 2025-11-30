using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using asp_net.Context;
using het_12._2.Models;

namespace het_12._2.Context
{
    public class KisallatsController : Controller
    {
        private readonly EFContext _context;

        public KisallatsController(EFContext context)
        {
            _context = context;
        }

        // GET: Kisallats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kisallats.ToListAsync());
        }

        // GET: Kisallats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kisallat = await _context.Kisallats
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kisallat == null)
            {
                return NotFound();
            }

            return View(kisallat);
        }

        // GET: Kisallats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kisallats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Age,Weigh,PhotoUrl,CategoryID")] Kisallat kisallat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kisallat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kisallat);
        }

        // GET: Kisallats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kisallat = await _context.Kisallats.FindAsync(id);
            if (kisallat == null)
            {
                return NotFound();
            }
            return View(kisallat);
        }

        // POST: Kisallats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Age,Weigh,PhotoUrl,CategoryID")] Kisallat kisallat)
        {
            if (id != kisallat.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kisallat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KisallatExists(kisallat.ID))
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
            return View(kisallat);
        }

        // GET: Kisallats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kisallat = await _context.Kisallats
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kisallat == null)
            {
                return NotFound();
            }

            return View(kisallat);
        }

        // POST: Kisallats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kisallat = await _context.Kisallats.FindAsync(id);
            if (kisallat != null)
            {
                _context.Kisallats.Remove(kisallat);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KisallatExists(int id)
        {
            return _context.Kisallats.Any(e => e.ID == id);
        }
    }
}
