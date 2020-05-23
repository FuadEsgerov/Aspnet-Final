using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class ServiceViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<ServiceSpec> Specs { get; set; }

    }
}
