using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class Portfolio:BaseEntities
    {
        public string ImgPath { get; set; }
        public string Name { get; set; }
        public string NameDesc { get; set; }
        public string Icon { get; set; }
    }
}
