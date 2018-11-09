using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab6.Data;

namespace Lab6.Controllers
{
    public class PoisController : Controller
    {
        private readonly PoiContext _context;

        public PoisController(PoiContext context)
        {
            _context = context;
        }

        // GET: Pois
        public async Task<IActionResult> Index()
        {
            return View(await _context.pois.ToListAsync());
        }

        // GET: Pois/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poi = await _context.pois
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        // GET: Pois/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pois/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Poi poi)
        {
            if (ModelState.IsValid)
            {
                poi.Id = Guid.NewGuid();
                _context.Add(poi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(poi);
        }

        // GET: Pois/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poi = await _context.pois.FindAsync(id);
            if (poi == null)
            {
                return NotFound();
            }
            return View(poi);
        }

        // POST: Pois/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Description")] Poi poi)
        {
            if (id != poi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(poi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoiExists(poi.Id))
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
            return View(poi);
        }

        // GET: Pois/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var poi = await _context.pois
                .FirstOrDefaultAsync(m => m.Id == id);
            if (poi == null)
            {
                return NotFound();
            }

            return View(poi);
        }

        // POST: Pois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var poi = await _context.pois.FindAsync(id);
            _context.pois.Remove(poi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoiExists(Guid id)
        {
            return _context.pois.Any(e => e.Id == id);
        }
    }
}
