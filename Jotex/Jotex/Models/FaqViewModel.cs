using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class FaqViewModel
    {
        public IEnumerable<Faq> Faqs { get; set; }
    }
}
