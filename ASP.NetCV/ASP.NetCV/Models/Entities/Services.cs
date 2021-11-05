using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class Services:BaseEntities
    {
        public string Name { get; set; } 
        public string  Description { get; set; }
        public ICollection<Icons> Icons { get; set; }

    }
}
