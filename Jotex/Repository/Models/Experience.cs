using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Experience:BaseEntity
    {
        public string Title { get; set; }
        public string Information { get; set; }
        public string Phone { get; set; }
      
        public string Video { get; set; }
        public string Phote { get; set; }
        public int Year { get; set; }
        public string Detail { get; set; }
    }
}
