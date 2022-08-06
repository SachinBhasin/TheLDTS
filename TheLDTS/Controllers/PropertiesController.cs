using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheLDTS.Data;
using TheLDTS.Models;

#nullable disable

namespace TheLDTS.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly TheLDTSContext _context;

        public PropertiesController(TheLDTSContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index(Landlord landlord)
        {
            var theLDTSContext = _context.Property.Include(a => a.Landlord);
            return View(await theLDTSContext.ToListAsync());
        }

        // GET: Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Property == null)
            {
                return NotFound();
            }

            var property = await _context.Property
                .Include(a => a.Landlord)
                .FirstOrDefaultAsync(m => m.PropertyId == id);
            if (property == null)
            {
                return NotFound();
            }

            return View(property);
        }

        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewData["LandlordID"] = new SelectList(_context.Landlord, "LandlordId", "LandlordId");
            return View();
        }

        // POST: Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyId,LandlordID,HouseNumber")] Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Add(property);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["LandlordID"] = new SelectList(_context.Landlord, "LandlordId", "LandlordId", property.LandlordID);
            return View(property);
        }

        // GET: Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Property == null)
            {
                return NotFound();
            }

            var property = await _context.Property.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }
            ViewData["LandlordID"] = new SelectList(_context.Landlord, "LandlordId", "LandlordId", property.LandlordID);
            return View(property);
        }

        // POST: Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PropertyId,LandlordID,HouseNumber")] Property property)
        {
            if (id != property.PropertyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(property.PropertyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["LandlordID"] = new SelectList(_context.Landlord, "LandlordId", "LandlordId", property.LandlordID);
            return View(property);
        }

        // GET: Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Property == null)
            {
                return NotFound();
            }

            var property = await _context.Property
                .Include(a => a.Landlord)
                .FirstOrDefaultAsync(m => m.PropertyId == id);
            if (property == null)
            {
                return NotFound();
            }

            return View(property);
        }

        // POST: Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Property == null)
            {
                return Problem("Entity set 'TheLDTSContext.Property'  is null.");
            }
            var property = await _context.Property.FindAsync(id);
            if (property != null)
            {
                _context.Property.Remove(property);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PropertyExists(int id)
        {
          return (_context.Property?.Any(e => e.PropertyId == id)).GetValueOrDefault();
        }
    }
}

#nullable enable
