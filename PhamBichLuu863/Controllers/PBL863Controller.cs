using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PhamBichLuu863.Data;
using PhamBichLuu863.Models;

namespace PhamBichLuu863.Controllers
{
    public class PBL863Controller : Controller
    {
        private readonly PBL863Context _context;

        public PBL863Controller(PBL863Context context)
        {
            _context = context;
        }

        // GET: PBL863
        public async Task<IActionResult> Index()
        {
            return View(await _context.PBL863.ToListAsync());
        }

        // GET: PBL863/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pBL863 = await _context.PBL863
                .FirstOrDefaultAsync(m => m.PBLID == id);
            if (pBL863 == null)
            {
                return NotFound();
            }

            return View(pBL863);
        }

        // GET: PBL863/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PBL863/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PBLID,PBLName,PBLGender")] PBL863 pBL863)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pBL863);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pBL863);
        }

        // GET: PBL863/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pBL863 = await _context.PBL863.FindAsync(id);
            if (pBL863 == null)
            {
                return NotFound();
            }
            return View(pBL863);
        }

        // POST: PBL863/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PBLID,PBLName,PBLGender")] PBL863 pBL863)
        {
            if (id != pBL863.PBLID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pBL863);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PBL863Exists(pBL863.PBLID))
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
            return View(pBL863);
        }

        // GET: PBL863/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pBL863 = await _context.PBL863
                .FirstOrDefaultAsync(m => m.PBLID == id);
            if (pBL863 == null)
            {
                return NotFound();
            }

            return View(pBL863);
        }

        // POST: PBL863/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pBL863 = await _context.PBL863.FindAsync(id);
            _context.PBL863.Remove(pBL863);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PBL863Exists(int id)
        {
            return _context.PBL863.Any(e => e.PBLID == id);
        }
    }
}
