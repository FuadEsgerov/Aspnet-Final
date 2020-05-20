using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class OurBestPlan:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
       
        [MaxLength(50)]
        public string HilightTag { get; set; }
        [Required]
        [MaxLength(50)]
        public string Detail1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Detail2 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Detail3 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Detail4 { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }

    }
}
