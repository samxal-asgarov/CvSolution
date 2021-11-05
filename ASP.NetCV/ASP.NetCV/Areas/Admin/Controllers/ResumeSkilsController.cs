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
    public class ResumeSkilsController : Controller
    {
        private readonly CvDbContext _context;

        public ResumeSkilsController(CvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ResumeSkils
        public async Task<IActionResult> Index()
        {
            return View(await _context.ResumeSkils.ToListAsync());
        }

        // GET: Admin/ResumeSkils/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeSkils = await _context.ResumeSkils
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeSkils == null)
            {
                return NotFound();
            }

            return View(resumeSkils);
        }

        // GET: Admin/ResumeSkils/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ResumeSkils/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SkillName,Name,NameDesc,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] ResumeSkils resumeSkils)
        {
            if (ModelState.IsValid)
            {
                _context.Add(resumeSkils);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(resumeSkils);
        }

        // GET: Admin/ResumeSkils/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeSkils = await _context.ResumeSkils.FindAsync(id);
            if (resumeSkils == null)
            {
                return NotFound();
            }
            return View(resumeSkils);
        }

        // POST: Admin/ResumeSkils/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SkillName,Name,NameDesc,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] ResumeSkils resumeSkils)
        {
            if (id != resumeSkils.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resumeSkils);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeSkilsExists(resumeSkils.Id))
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
            return View(resumeSkils);
        }

        // GET: Admin/ResumeSkils/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resumeSkils = await _context.ResumeSkils
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resumeSkils == null)
            {
                return NotFound();
            }

            return View(resumeSkils);
        }

        // POST: Admin/ResumeSkils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resumeSkils = await _context.ResumeSkils.FindAsync(id);
            _context.ResumeSkils.Remove(resumeSkils);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeSkilsExists(int id)
        {
            return _context.ResumeSkils.Any(e => e.Id == id);
        }
    }
}
