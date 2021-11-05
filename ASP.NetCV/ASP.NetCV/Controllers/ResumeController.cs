using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Controllers
{
    public class ResumeController : Controller
    {
        readonly CvDbContext db;
        public ResumeController(CvDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            Resume resume = new Resume();
            resume.Bio = db.BioSkilsInfos.FirstOrDefault(b => b.DeletedByUserID == null);
            resume.ResumeSkils = db.ResumeSkils.Where(b => b.DeletedByUserID == null).ToList();
            resume.Expirences = db.Expirences.Where(b => b.DeletedByUserID == null).ToList(); 
            resume.ResumeBackgrounds = db.ResumeBackgrounds.Where(b => b.DeletedByUserID == null).ToList();
            return View(resume);
        }
    }
}
