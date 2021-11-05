using ASP.NetCV.Models.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.AppCode.Components
{
    public class UserInfoViewComponent:ViewComponent
    {
        readonly CvDbContext db;
        public UserInfoViewComponent(CvDbContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult>  InvokeAsync()
        {
            var user = await db.userInfos.FirstOrDefaultAsync();
            return View(user);
        }
    }
}
