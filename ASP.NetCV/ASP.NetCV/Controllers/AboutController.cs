using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Controllers
{
    public class AboutController : Controller
    {
        readonly CvDbContext db;
        public AboutController(CvDbContext db)
        {
            this.db = db;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            AboutInfo about = new AboutInfo();
            about.Work = db.Works.FirstOrDefault(b => b.DeletedByUserID == null);
            about.Icons = db.Icons.Where(b => b.DeletedByUserID == null).ToList();
            about.Services = db.Services

                .Include(a=>a.Icons)
                .Where(b => b.DeletedByUserID == null ).ToList();


            about.Skills = db.Skills.Where(b => b.DeletedByUserID == null).ToList();
            about.UserInfo = db.userInfos.FirstOrDefault(b => b.DeletedByUserID == null);




            return View(about);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
