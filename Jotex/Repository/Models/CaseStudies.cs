using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class CaseStudies:BaseEntity
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Client { get; set; }
        public string Location { get; set; }
        public string Caregories { get; set; }
        public string Tags { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Challenge { get; set; }
        public string Solution { get; set; }
        public string Result { get; set; }




    }
}
