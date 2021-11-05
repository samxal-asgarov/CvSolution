using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace ASP.NetCV.AppCode.Application.BlogModule
{
    public class BlogsViewModel
    {
        [Required]
        public string Tittle { get; set; }
        public string Body { get; set; }
        public string ImgPath { get; set; }
        public string Desc { get; set; }
        public IFormFile file { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublishUser { get; set; }
        public int Id { get; set; }

    }
}