using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class CaseViewModel
    {
        public IEnumerable<OurAgent> OurAgents { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<CaseStudy> CaseStudies { get; set; }
        public ICollection<CaseStudySpec> CaseStudySpecs { get; set; }

        public Setting Setting { get; set; }
    }
}
