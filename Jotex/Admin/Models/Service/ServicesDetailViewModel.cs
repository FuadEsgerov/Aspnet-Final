using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Service
{
    public class ServicesDetailViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
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
   
    }
}
