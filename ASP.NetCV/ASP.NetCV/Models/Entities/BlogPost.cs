using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class BlogPost:BaseEntities
    {
 
        public string ImgPath { get; set; }
        public string Tittle { get; set; }
        public DateTime PublishDate { get; set; }
        public string PublishUser { get; set; }
        public string Body { get; set; }
        public string  Desc { get; set; }


    }
}
