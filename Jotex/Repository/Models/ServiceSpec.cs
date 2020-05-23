using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ServiceSpec : BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required]
        [MaxLength(100)]
        public string Value { get; set; }
        [Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

    }
}
