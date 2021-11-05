using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using MediatR;
using ASP.NetCV.AppCode.Application.BlogModule;

namespace ASP.NetCV.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostsController : Controller
    {
        private readonly CvDbContext _context;
        private readonly IMediator mediator;
        public BlogPostsController(CvDbContext context, IMediator mediator)
        {

            _context =context;
            this.mediator = mediator;
        }

        // GET: Admin/BlogPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.BlogPosts.ToListAsync());
        }

        // GET: Admin/BlogPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            BlogSingleQuery query = new BlogSingleQuery
            {
                Id = id
            };

            BlogPost blog = await mediator.Send(query);//queryni gonderir mediatdra mediatr analiz edir eger bu querydise okei edir ise salir


            if (blog == null)
            {
                return NotFound();
            }

            return View(blog);
        }

        // GET: Admin/BlogPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/BlogPosts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogsCreateComman comman)
        {


            BlogPost model = await mediator.Send(comman);

            if (model != null)

                return RedirectToAction(nameof(Index));

            return View(comman);
        }

        // GET: Admin/BlogPosts/Edit/5
        public async Task<IActionResult> Edit(BlogSingleQuery query)
        {
            var respons = await mediator.Send(query);

            if (respons == null)
            {
                return NotFound();
            }
            BlogsViewModel vm = new BlogsViewModel();

            vm.Tittle = respons.Tittle;
            vm.PublishDate = respons.PublishDate;
            vm.ImgPath = respons.ImgPath;
            vm.Desc = respons.Desc;
            vm.PublishUser = respons.PublishUser;

            return View(vm);
        }

        // POST: Admin/BlogPosts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BlogsEditCommand command)
        {
            var id = await mediator.Send(command);

            if (id > 0)

                return RedirectToAction(nameof(Index));

            return View(command);
        }

        // GET: Admin/BlogPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogPost = await _context.BlogPosts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogPost == null)
            {
                return NotFound();
            }

            return View(blogPost);
        }

        // POST: Admin/BlogPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            _context.BlogPosts.Remove(blogPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogPostExists(int id)
        {
            return _context.BlogPosts.Any(e => e.Id == id);
        }
    }
}
