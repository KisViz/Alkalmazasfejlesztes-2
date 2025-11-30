using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using het12._2.Context;
using het12._2.Models;

namespace het12._2.Controllers
{
    public class PuppiesController : Controller
    {
        private readonly EFContext _context;

        public PuppiesController(EFContext context)
        {
            _context = context;
        }

        // GET: Puppies
        public async Task<IActionResult> Index()
        {
            var eFContext = _context.Puppies.Include(p => p.ReferencedCategory);
            return View(await eFContext.ToListAsync());
        }

        // GET: Puppies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puppy = await _context.Puppies
                .Include(p => p.ReferencedCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (puppy == null)
            {
                return NotFound();
            }

            return View(puppy);
        }

        // GET: Puppies/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Description");
            return View();
        }

        // POST: Puppies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,Weigh,photoLink,CategoryId")] Puppy puppy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(puppy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Description", puppy.CategoryId);
            return View(puppy);
        }

        // GET: Puppies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puppy = await _context.Puppies.FindAsync(id);
            if (puppy == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Description", puppy.CategoryId);
            return View(puppy);
        }

        // POST: Puppies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,Weigh,photoLink,CategoryId")] Puppy puppy)
        {
            if (id != puppy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(puppy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuppyExists(puppy.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Description", puppy.CategoryId);
            return View(puppy);
        }

        // GET: Puppies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puppy = await _context.Puppies
                .Include(p => p.ReferencedCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (puppy == null)
            {
                return NotFound();
            }

            return View(puppy);
        }

        // POST: Puppies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var puppy = await _context.Puppies.FindAsync(id);
            if (puppy != null)
            {
                _context.Puppies.Remove(puppy);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuppyExists(int id)
        {
            return _context.Puppies.Any(e => e.Id == id);
        }
    }
}
