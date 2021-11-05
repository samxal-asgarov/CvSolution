using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class Work: BaseEntities
    {
        public string WorkDesc { get; set; }
        public string WorkShortDesc { get; set; }
        public string WorkLongDesc { get; set; }
    }
}
