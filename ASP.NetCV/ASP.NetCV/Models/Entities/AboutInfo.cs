using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class AboutInfo
    {

        public  Work Work { get; set; }
      
        public List<Skills> Skills { get; set; }
        public UserInfo UserInfo { get; set; }
        public List<Icons> Icons { get; set; }
        public List<Services> Services { get; set; }

    }
}
