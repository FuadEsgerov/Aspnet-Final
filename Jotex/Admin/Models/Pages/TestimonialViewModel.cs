using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class TestimonialViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Rəy daxil edin....")]
        [MaxLength(500, ErrorMessage = "Sual 500 xarakterdən çox ola bilməz")]
        public string Review { get; set; }
        [Required(ErrorMessage = "Adını qeyd edin....")]
        [MaxLength(500, ErrorMessage = "Cavab 50 xarakterdən çox ola bilməz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Gördüyü işi qeyd edin....")]
        [MaxLength(500, ErrorMessage = "Cavab 50 xarakterdən çox ola bilməz")]
        public string UserProfession { get; set; }
    }
}
