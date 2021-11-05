using ASP.NetCV.Models.DataContext;
using ASP.NetCV.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ASP.NetCV.AppCode.Application.BlogModule
{
    public class BlogSingleQuery:IRequest<BlogPost>

    {
        //axtaris etmek ucun id getirmek ucun yazilir query!
        public int? Id { get; set; }

        public class BlogSingleQueryHandler : IRequestHandler<BlogSingleQuery, BlogPost>
        {   //nested clasdir clas icinde clas yazilir 
            readonly CvDbContext db;
            public BlogSingleQueryHandler(CvDbContext db)
            {
                this.db = db; //Model
            }
            //query service adlanir
            public async Task<BlogPost> Handle(BlogSingleQuery request, CancellationToken cancellationToken)
            {
                if (request.Id <= 0 || request.Id==null)
                {
                    return null;
                }
                var blog = await db.BlogPosts.FirstOrDefaultAsync(m => m.Id == request.Id);

                return blog;
            }
        }
    }
}
