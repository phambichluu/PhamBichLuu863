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
    public class PersonPBL863Controller : Controller
    {
        private readonly PBL863Context _context;

        public PersonPBL863Controller(PBL863Context context)
        {
            _context = context;
        }

        // GET: PersonPBL863
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonPBL863.ToListAsync());
        }

        // GET: PersonPBL863/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPBL863 = await _context.PersonPBL863
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personPBL863 == null)
            {
                return NotFound();
            }

            return View(personPBL863);
        }

        // GET: PersonPBL863/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonPBL863/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,PersonName")] PersonPBL863 personPBL863)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personPBL863);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personPBL863);
        }

        // GET: PersonPBL863/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPBL863 = await _context.PersonPBL863.FindAsync(id);
            if (personPBL863 == null)
            {
                return NotFound();
            }
            return View(personPBL863);
        }

        // POST: PersonPBL863/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,PersonName")] PersonPBL863 personPBL863)
        {
            if (id != personPBL863.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personPBL863);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonPBL863Exists(personPBL863.PersonID))
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
            return View(personPBL863);
        }

        // GET: PersonPBL863/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPBL863 = await _context.PersonPBL863
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (personPBL863 == null)
            {
                return NotFound();
            }

            return View(personPBL863);
        }

        // POST: PersonPBL863/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personPBL863 = await _context.PersonPBL863.FindAsync(id);
            _context.PersonPBL863.Remove(personPBL863);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonPBL863Exists(string id)
        {
            return _context.PersonPBL863.Any(e => e.PersonID == id);
        }
    }
}
