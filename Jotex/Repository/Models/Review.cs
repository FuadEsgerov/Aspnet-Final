using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
   public class Review :BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Text { get; set; }
        public string Insurance { get; set; }
    }
}
