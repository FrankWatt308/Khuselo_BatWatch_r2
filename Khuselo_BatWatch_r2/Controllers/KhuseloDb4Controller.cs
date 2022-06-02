using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Khuselo_BatWatch_r2.Models;

namespace Khuselo_BatWatch_r2.Controllers
{
    public class KhuseloDb4Controller : Controller
    {
        private readonly Khuselo_4Context _context;



        public KhuseloDb4Controller(Khuselo_4Context context)
        {
            _context = context;
        }

        // GET: KhuseloDb4
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["GetSearch"] = searchString;
            var searQuery = from x in _context.KhuseloDb4s select x;
            if (!string.IsNullOrEmpty(searchString))
            {

                searQuery = (searQuery.Where(x => x.Serial.Equals(Convert.ToInt32(searchString))));
                return View(await searQuery.AsNoTracking().ToListAsync());
            }

            else
            {
                return _context.KhuseloDb4s != null ?
            View(await _context.KhuseloDb4s.ToListAsync()) :
            Problem("Entity set 'Khuselo_4Context.KhuseloDb4s'  is null.");
            }

        }
        public async Task<IActionResult> Index2()
        {
            return _context.KhuseloDb4s != null ?
                        View(await _context.KhuseloDb4s.ToListAsync()) :
                        Problem("Entity set 'Khuselo_4Context.KhuseloDb4s'  is null.");
        }
        public async Task<IActionResult> Index3()
        {
            return _context.KhuseloDb4s != null ?
                        View(await _context.KhuseloDb4s.ToListAsync()) :
                        Problem("Entity set 'Khuselo_4Context.KhuseloDb4s'  is null.");
        }
        public async Task<IActionResult> Index4()
        {
            return _context.KhuseloDb4s != null ?
                        View(await _context.KhuseloDb4s.ToListAsync()) :
                        Problem("Entity set 'Khuselo_4Context.KhuseloDb4s'  is null.");
        }

        // GET: KhuseloDb4/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.KhuseloDb4s == null)
            {
                return NotFound();
            }

            var khuseloDb4 = await _context.KhuseloDb4s
                .FirstOrDefaultAsync(m => m.Serial == id);
            if (khuseloDb4 == null)
            {
                return NotFound();
            }

            return View(khuseloDb4);
        }

        // GET: KhuseloDb4/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KhuseloDb4/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Serial,Brand,Date,Branch,Price,Location,TechnName,TechCell,DateExpired,DateInstalled,ChargeCycles")] KhuseloDb4 khuseloDb4)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khuseloDb4);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khuseloDb4);
        }

        // GET: KhuseloDb4/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.KhuseloDb4s == null)
            {
                return NotFound();
            }

            var khuseloDb4 = await _context.KhuseloDb4s.FindAsync(id);
            if (khuseloDb4 == null)
            {
                return NotFound();
            }
            return View(khuseloDb4);
        }

        // POST: KhuseloDb4/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Serial,Brand,Date,Branch,Price,Location,TechnName,TechCell,DateExpired,DateInstalled,ChargeCycles")] KhuseloDb4 khuseloDb4)
        {
            if (id != khuseloDb4.Serial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khuseloDb4);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhuseloDb4Exists(khuseloDb4.Serial))
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
            return View(khuseloDb4);
        }

        // GET: KhuseloDb4/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.KhuseloDb4s == null)
            {
                return NotFound();
            }

            var khuseloDb4 = await _context.KhuseloDb4s
                .FirstOrDefaultAsync(m => m.Serial == id);
            if (khuseloDb4 == null)
            {
                return NotFound();
            }

            return View(khuseloDb4);
        }

        // POST: KhuseloDb4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.KhuseloDb4s == null)
            {
                return Problem("Entity set 'Khuselo_4Context.KhuseloDb4s'  is null.");
            }
            var khuseloDb4 = await _context.KhuseloDb4s.FindAsync(id);
            if (khuseloDb4 != null)
            {
                _context.KhuseloDb4s.Remove(khuseloDb4);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhuseloDb4Exists(int id)
        {
            return (_context.KhuseloDb4s?.Any(e => e.Serial == id)).GetValueOrDefault();
        }
    }
}
