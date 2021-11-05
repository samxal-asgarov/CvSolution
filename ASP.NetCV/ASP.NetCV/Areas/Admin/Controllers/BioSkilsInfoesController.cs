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
    public class BioSkilsInfoesController : Controller
    {
        private readonly CvDbContext _context;

        public BioSkilsInfoesController(CvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/BioSkilsInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.BioSkilsInfos.ToListAsync());
        }

        // GET: Admin/BioSkilsInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bioSkilsInfo = await _context.BioSkilsInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bioSkilsInfo == null)
            {
                return NotFound();
            }

            return View(bioSkilsInfo);
        }

        // GET: Admin/BioSkilsInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BioSkilsInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Desc1,Desc2,Desc3,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] BioSkilsInfo bioSkilsInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bioSkilsInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bioSkilsInfo);
        }

        // GET: Admin/BioSkilsInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bioSkilsInfo = await _context.BioSkilsInfos.FindAsync(id);
            if (bioSkilsInfo == null)
            {
                return NotFound();
            }
            return View(bioSkilsInfo);
        }

        // POST: Admin/BioSkilsInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Desc1,Desc2,Desc3,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] BioSkilsInfo bioSkilsInfo)
        {
            if (id != bioSkilsInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bioSkilsInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BioSkilsInfoExists(bioSkilsInfo.Id))
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
            return View(bioSkilsInfo);
        }

        // GET: Admin/BioSkilsInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bioSkilsInfo = await _context.BioSkilsInfos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bioSkilsInfo == null)
            {
                return NotFound();
            }

            return View(bioSkilsInfo);
        }

        // POST: Admin/BioSkilsInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bioSkilsInfo = await _context.BioSkilsInfos.FindAsync(id);
            _context.BioSkilsInfos.Remove(bioSkilsInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BioSkilsInfoExists(int id)
        {
            return _context.BioSkilsInfos.Any(e => e.Id == id);
        }
    }
}
