using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class Icons:BaseEntities
    {
        public string Icon { get; set; }
        public int ServiceID { get; set; }
        public virtual Services  Service { get; set; }
    }
}
