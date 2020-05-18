using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class OurAgent:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Job { get; set; }
        public string Photo { get; set; }

    }
}
