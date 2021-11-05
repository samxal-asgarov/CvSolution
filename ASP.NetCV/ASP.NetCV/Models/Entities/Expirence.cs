using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class Expirence:BaseEntities
    {
        public string Date { get; set; }
        public string ExpierenceName { get; set; }
        public string ExpirenceWork { get; set; }
        public string ExpirenceLocation { get; set; }
        public string ExpierenceDesc { get; set; }
        public string ImgPath { get; set; }
    }
}
