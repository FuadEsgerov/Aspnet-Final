using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class OurPlan:BaseEntity
    {
        public string Title { get; set; }
        public string Logo { get; set; }
        public string HilightTag { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public string Detail3 { get; set; }
        public string Detail4 { get; set; }

    }
}
