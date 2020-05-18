using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class AboutUs:BaseEntity
    {
        public string Title { get; set; }
        public string Information { get; set; }


        public string Detail { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string EndPoint { get; set; }
    }
}
