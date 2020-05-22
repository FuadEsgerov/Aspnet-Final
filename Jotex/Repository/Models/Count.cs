using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Count : BaseEntity
    {
        [Required]
        public string CountNumber { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
