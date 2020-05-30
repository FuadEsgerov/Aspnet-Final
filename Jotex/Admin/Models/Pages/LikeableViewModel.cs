using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class LikeableViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Başlıq vacibdir")]
        [MaxLength(200, ErrorMessage = "Başlıq 200 xarakterdən çox ola bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Məlumat vacibdir")]
        [MaxLength(300, ErrorMessage = "Məlumat 300 xarakterdən çox ola bilməz")]
        public string Information { get; set; }
        [Required(ErrorMessage = "Yazı vacibdir")]
        [MaxLength(50, ErrorMessage = "Yazı 50 xarakterdən çox ola bilməz")]
        public string CallUs { get; set; }
        [Required(ErrorMessage = "Nömrə vacibdir")]
        [MaxLength(50, ErrorMessage = "Nömrə 50 xarakterdən çox ola bilməz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Link vacibdir")]
        [MaxLength(100, ErrorMessage = "Link 100 xarakterdən çox ola bilməz")]
        public string EndPoint { get; set; }
        [Required(ErrorMessage = "Video vacibdir")]
        [MaxLength(150, ErrorMessage = "Video 150 xarakterdən çox ola bilməz")]

        public string Video { get; set; }
        [Required(ErrorMessage = "Şəkil vacibdir")]
        [MaxLength(100, ErrorMessage = "Şəkil 100 xarakterdən çox ola bilməz")]
        public string Phote { get; set; }
        [Required(ErrorMessage = "İl vacibdir")]
        [MaxLength(50, ErrorMessage = "İl 50 xarakterdən çox ola bilməz")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Təcrübə vacibdir")]
        [MaxLength(50, ErrorMessage = "Təcrübə 100 xarakterdən çox ola bilməz")]
        public string Experience { get; set; }
        [Required(ErrorMessage = "Hərəkət yazısı vacibdir")]
        [MaxLength(100, ErrorMessage = "Hərəkət yazısı 100 xarakterdən çox ola bilməz")]
        public string ActionText { get; set; }
    }
}
