using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Faq:BaseEntity
    {

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string CoverImage { get; set; }
        [Required]
        [MaxLength(100)]
        public string Question { get; set; }
        [Required]
        [MaxLength(200)]
        public string Answer { get; set; }

    }
}
