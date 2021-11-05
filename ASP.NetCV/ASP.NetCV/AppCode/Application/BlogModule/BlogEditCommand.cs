using ASP.NetCV.AppCode.Extensions;
using ASP.NetCV.Models.DataContext;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ASP.NetCV.AppCode.Application.BlogModule
{
    public class BlogsEditCommand : BlogsViewModel, IRequest<int>
    {


        public class BlogsEditCommandHandler : IRequestHandler<BlogsEditCommand, int>
        {
            readonly CvDbContext db;
            readonly IActionContextAccessor ctx;
            readonly IWebHostEnvironment env;


            public BlogsEditCommandHandler(CvDbContext db, IActionContextAccessor ctx, IWebHostEnvironment env)
            {
                this.db = db;
                this.ctx = ctx;
                this.env = env;
            }
            public async Task<int> Handle(BlogsEditCommand request, CancellationToken cancellationToken)
            {

                if (request.Id!= request.Id)
                {
                    return 0;
                }


                if (string.IsNullOrWhiteSpace(request.ImgPath) && request.file == null)
                {

                    ctx.ActionContext.ModelState.AddModelError("file", "Not Chosen");
                }

                var entity = await db.BlogPosts.FirstOrDefaultAsync(b => b.Id == request.Id && b.DeletedByUserID == null);

                if (entity == null)
                {
                    return 0;
                }

                if (ctx.ModelStateValid())
                {
                    entity.Tittle = request.Tittle;
                    entity.PublishDate = request.PublishDate;
                    entity.ImgPath= request.ImgPath;
                    entity.Desc= request.Desc;
                    entity.PublishUser = request.PublishUser;





                    if (request.file != null)
                    {

                        string extension = Path.GetExtension(request.file.FileName);  //.jpg tapmaq ucundur.

                        request.ImgPath = $"{Guid.NewGuid()}{extension}";//imagenin name 


                        string phsicalFileName = Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", request.ImgPath);

                        using (var stream = new FileStream(phsicalFileName, FileMode.Create, FileAccess.Write))
                        {
                            await request.file.CopyToAsync(stream);
                        }

                        if (!string.IsNullOrWhiteSpace(entity.ImgPath))
                        {
                            System.IO.File.Delete(Path.Combine(env.ContentRootPath, "wwwroot", "uploads", "images", entity.ImgPath));

                        }
                        entity.ImgPath = request.ImgPath;
                    }

                    await db.SaveChangesAsync(cancellationToken);
                    return entity.Id;



                }
                return 0;

            }

        }
    }
}
