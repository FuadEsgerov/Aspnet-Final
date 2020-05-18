using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Faq:BaseEntity
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}
