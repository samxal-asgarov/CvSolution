using ASP.NetCV.Models.DataContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Controllers
{
    public class BlogController : Controller
    {
       
        readonly CvDbContext db;
        public BlogController(CvDbContext db)
        {
            this.db = db;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var data = db.BlogPosts.Where(b => b.DeletedByUserID == null).ToList();

            return View(data);
        }
        public IActionResult Details(int id)
        {
            var data = db.BlogPosts.FirstOrDefault(b => b.Id == id);
           

            return View(data);
        }

    }
}
