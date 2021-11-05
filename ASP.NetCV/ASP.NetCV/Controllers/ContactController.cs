using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Controllers
{
    public class ContactController : Controller
    {
        readonly CvDbContext db;
        public ContactController(CvDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ContactUs(ContactPost model)
        {
            if (ModelState.IsValid)
            {
                db.Add(model);
                db.SaveChanges();
                return Json(new
                {
                    error = false,
                    message = "Sizin muracietiniz qeyde alindi"

                });
            }

            return Json(new
            {
                error = true,
                message = "Sizin muracietiniz qeyde alinmadi,zehmet olmasa yeniden yoxlayin"

            });
        }
            
        


    }
}
