using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class About : BaseEntity
    {

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [Required]
        public decimal PolicyCount { get; set; }
        [Required]
        [MaxLength(100)]
        public string PolicyText { get; set; }
        [Required]
        [MaxLength(50)]
        public string PolicyActionText { get; set; }
        [Required]
        public decimal ClaimPercent { get; set; }
        [Required]
        [MaxLength(100)]
        public string ClaimText { get; set; }
        [Required]
        [MaxLength(50)]
        public string ClaimActionText { get; set; }
        [Required]
        public int OfficeCount { get; set; }
        [Required]
        [MaxLength(100)]
        public string OfficeText { get; set; }
        [Required]
        [MaxLength(50)]
        public string OfficeActionText { get; set; }

        public IEnumerable<OurAgent> Agents { get; set; }

    }
}
