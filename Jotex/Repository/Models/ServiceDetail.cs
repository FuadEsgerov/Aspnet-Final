using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class ServiceDetail:BaseEntity
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(700)]
        public string Detail { get; set; }
        [Required]
        [MaxLength(200)]
        public string SubDetail { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string Document { get; set; }
 
        [Required]
        [MaxLength(200)]
        public string Information { get; set; }
        public Service Service { get; set; }
     
    }
}
