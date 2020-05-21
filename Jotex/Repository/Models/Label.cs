using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Label : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }

        public ICollection<OurBestPlan> Plans { get; set; }
    }
}
