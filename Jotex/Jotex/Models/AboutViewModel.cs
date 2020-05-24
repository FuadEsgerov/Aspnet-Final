using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class AboutViewModel
    {
        public IEnumerable<About> Abouts { get; set; }
        public Setting Settings { get; set; }
        public IEnumerable<OurAgent> Agents { get; set; }


    }
}
