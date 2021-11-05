using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCV.Models.Entities
{
    public class Resume
    {
        public BioSkilsInfo Bio { get; set; }
        public List<ResumeSkils> ResumeSkils { get; set; }
        public List<Expirence>Expirences { get; set; }
        public List<ResumeBackground> ResumeBackgrounds { get; set; }

    }
}
