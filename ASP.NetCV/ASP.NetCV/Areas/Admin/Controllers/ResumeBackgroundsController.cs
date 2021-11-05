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
    public class ResumeBackgroundsController : Controller
    {
        private readonly CvDbContext _context;

        public ResumeBackgroundsController(CvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ResumeBackgrounds
        public async Task<IActionResult> Index()
        {
            return View(await _context.ResumeBackgrounds.ToListAsync());
        }

        // GET: Admin/ResumeBackgrounds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeBackground = await _context.ResumeBackgrounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeBackground == null)
            {
                return NotFound();
            }

            return View(resumeBackground);
        }

        // GET: Admin/ResumeBackgrounds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ResumeBackgrounds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,ExpierenceName,ExpirenceWork,ExpirenceLocation,ExpierenceDesc,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] ResumeBackground resumeBackground)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resumeBackground);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resumeBackground);
        }

        // GET: Admin/ResumeBackgrounds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeBackground = await _context.ResumeBackgrounds.FindAsync(id);
            if (resumeBackground == null)
            {
                return NotFound();
            }
            return View(resumeBackground);
        }

        // POST: Admin/ResumeBackgrounds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Date,ExpierenceName,ExpirenceWork,ExpirenceLocation,ExpierenceDesc,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] ResumeBackground resumeBackground)
        {
            if (id != resumeBackground.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resumeBackground);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeBackgroundExists(resumeBackground.Id))
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
            return View(resumeBackground);
        }

        // GET: Admin/ResumeBackgrounds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeBackground = await _context.ResumeBackgrounds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeBackground == null)
            {
                return NotFound();
            }

            return View(resumeBackground);
        }

        // POST: Admin/ResumeBackgrounds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resumeBackground = await _context.ResumeBackgrounds.FindAsync(id);
            _context.ResumeBackgrounds.Remove(resumeBackground);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeBackgroundExists(int id)
        {
            return _context.ResumeBackgrounds.Any(e => e.Id == id);
        }
    }
}
