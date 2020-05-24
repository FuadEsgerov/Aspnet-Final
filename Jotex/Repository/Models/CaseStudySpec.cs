using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class CaseStudySpec:BaseEntity
    {
        public int OrderBy { get; set; }
        [Required]
        [MaxLength(100)]
        public string Key { get; set; }
        [Required]
        [MaxLength(100)]
        public string Value { get; set; }
        [Required]
        public int CaseStudyId { get; set; }
        public CaseStudy CaseStudy { get; set; }
    }
}
