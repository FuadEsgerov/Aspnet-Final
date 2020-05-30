using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class AboutUsViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(300)]
        public string Information { get; set; }
        [Required]
        [MaxLength(300)]
        public string SubDetail { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

    }
}
