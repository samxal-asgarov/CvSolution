using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Controllers
{
    public class PortfolioController : Controller
    {
        readonly CvDbContext db;
        public PortfolioController(CvDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var data = db.Portfolios.Where(p => p.DeletedByUserID == null).ToList();
            return View(data);
        }
    }
}
