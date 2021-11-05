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
    public class ContactPostsController : Controller
    {
        private readonly CvDbContext _context;

        public ContactPostsController(CvDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ContactPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactPosts.ToListAsync());
        }

        // GET: Admin/ContactPosts/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await _context.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == id && m.DeletedByUserID==null );
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);

        }

        [HttpPost]

        public async Task<IActionResult> Answer([Bind("Id,Answer")] ContactPost model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            
     
            var contactPost = await _context.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == model.Id && m.AnswerByUserID==null && m.DeletedByUserID == null);
            if (contactPost == null)
            {
                return NotFound();
            }
            contactPost.Answer = model.Answer;
            contactPost.AnswerDate = DateTime.Now;
            contactPost.AnswerByUserID = 1;
            await  _context.SaveChangesAsync();

            return Redirect(nameof(Index));
            
        }

        // GET: Admin/ContactPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/ContactPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Content,Subject,Answer,AnswerDate,AnswerByUserID,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] ContactPost contactPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contactPost);
        }

        // GET: Admin/ContactPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await _context.ContactPosts.FindAsync(id);
            if (contactPost == null)
            {
                return NotFound();
            }
            return View(contactPost);
        }

        // POST: Admin/ContactPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Email,Content,Subject,Answer,AnswerDate,AnswerByUserID,Id,CreatByUserId,CreatDate,DeletedByUserID,DeletedDate")] ContactPost contactPost)
        {
            if (id != contactPost.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactPostExists(contactPost.Id))
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
            return View(contactPost);
        }

        // GET: Admin/ContactPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactPost = await _context.ContactPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactPost == null)
            {
                return NotFound();
            }

            return View(contactPost);
        }

        // POST: Admin/ContactPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contactPost = await _context.ContactPosts.FindAsync(id);
            _context.ContactPosts.Remove(contactPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContactPostExists(int id)
        {
            return _context.ContactPosts.Any(e => e.Id == id);
        }
    }
}
