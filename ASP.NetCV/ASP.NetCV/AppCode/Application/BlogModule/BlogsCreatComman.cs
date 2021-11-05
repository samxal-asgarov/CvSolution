using ASP.NetCV.AppCode.Extensions;
using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ASP.NetCV.AppCode.Application.BlogModule
{

    public class BlogsCreateComman : IRequest<BlogPost>
    {
       

        public string ImgPath { get; set; }
        public string Tittle { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublishUser { get; set; }
        public string Body { get; set; }
        public string Desc { get; set; }
        public IFormFile file { get; set; }

        public class BlogsCreateCommanHandler : IRequestHandler<BlogsCreateComman, BlogPost>
        {
            readonly CvDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;
            public BlogsCreateCommanHandler(CvDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env) //Model.State burda yoxlamaq ucun yazilib.
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<BlogPost> Handle(BlogsCreateComman model, CancellationToken cancellationToken)
            {


                if (ctx.ModelStateValid())
                {
                    BlogPost blog = new BlogPost();
                    string extension = Path.GetExtension(model.file.FileName);  //.jpg tapmaq ucundur. png .gng 

                    blog.ImgPath = $"{Guid.NewGuid()}{extension}";//imagenin name 


                    string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", blog.ImgPath);

                    using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                    {
                        await model.file.CopyToAsync(stream);
                    }

                    blog.Tittle = blog.Tittle;
                    blog.Desc = model.Desc;
                    blog.Body = model.Body;
                    blog.PublishDate = DateTime.Now;
                    blog.PublishUser = model.PublishUser;
                 


                    db.Add(blog);
                    await db.SaveChangesAsync(cancellationToken);

                    return blog;

                }
                return null;
            }
        }


    }
}


   
  
