using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class OurBestPlanViewModel
    {
     
        public string Title { get; set; }
   
        public string Logo { get; set; }

        public string Detail1 { get; set; }
    
        public string Detail2 { get; set; }
 
        public string Detail3 { get; set; }

        public string Detail4 { get; set; }
 
        public string ActionText { get; set; }

        public string EndPoint { get; set; }
        public LabelViewModel Label { get; set; }
    }
}
