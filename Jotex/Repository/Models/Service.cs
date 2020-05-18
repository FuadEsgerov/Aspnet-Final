using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Service:BaseEntity
    {
        [Required]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public Company Company { get; set; }
    }
}
