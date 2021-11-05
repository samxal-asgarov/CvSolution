using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;

namespace ASP.NetCV.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExpirencesController : Controller
    {
        private readonly CvDbContext _context;

        public ExpirencesController(CvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Expirences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Expirences.ToListAsync());
        }

        // GET: Admin/Expirences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expirence = await _context.Expirences
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expirence == null)
            {
                return NotFound();
            }

            return View(expirence);
        }

        // GET: Admin/Expirences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Expirences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,ExpierenceName,ExpirenceWork,ExpirenceLocation,ExpierenceDesc,ImgPath,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] Expirence expirence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expirence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expirence);
        }

        // GET: Admin/Expirences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expirence = await _context.Expirences.FindAsync(id);
            if (expirence == null)
            {
                return NotFound();
            }
            return View(expirence);
        }

        // POST: Admin/Expirences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,ExpierenceName,ExpirenceWork,ExpirenceLocation,ExpierenceDesc,ImgPath,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] Expirence expirence)
        {
            if (id != expirence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expirence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpirenceExists(expirence.Id))
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
            return View(expirence);
        }

        // GET: Admin/Expirences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expirence = await _context.Expirences
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expirence == null)
            {
                return NotFound();
            }

            return View(expirence);
        }

        // POST: Admin/Expirences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var expirence = await _context.Expirences.FindAsync(id);
            _context.Expirences.Remove(expirence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpirenceExists(int id)
        {
            return _context.Expirences.Any(e => e.Id == id);
        }
    }
}
