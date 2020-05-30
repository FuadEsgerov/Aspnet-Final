using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class CaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
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
       
    }
}
