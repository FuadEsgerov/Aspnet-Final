using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class CaseStudy : BaseEntity
    {

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Detail { get; set; }
        [Required]
        [MaxLength(500)]
        public string SubDetail { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Challenge { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Solution { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Result { get; set; }
        public IEnumerable<CaseStudySpec> Specs { get; set; }

    }
}
