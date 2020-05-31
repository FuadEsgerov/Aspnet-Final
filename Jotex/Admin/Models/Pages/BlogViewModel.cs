using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage = "Başlıq vacibdir")]
        [MaxLength(200, ErrorMessage = "Başlıq 200 xarakterdən çox ola bilməz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mətn vacibdir")]
        [MaxLength(1000, ErrorMessage = "Mətn 1000 xarakterdən çox ola bilməz")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Taq vacibdir")]
        [MaxLength(50, ErrorMessage = "Taq 50 xarakterdən çox ola bilməz")]
        public string Tag { get; set; }
     
        [MaxLength(100, ErrorMessage = "Şəkil 100 xarakterdən çox ola bilməz")]
        public string Image { get; set; }

        [MaxLength(100, ErrorMessage = "Video 100 xarakterdən çox ola bilməz")]
        public string Video { get; set; }
        [Required(ErrorMessage = "Yardımcı başlıq vacibdir")]
        [MaxLength(200, ErrorMessage = "Yardımcı başlıq 200 xarakterdən çox ola bilməz")]
        public string SubTitle { get; set; }
        [Required(ErrorMessage = "Slogan vacibdir")]
        [MaxLength(400, ErrorMessage = "Slogan 400 xarakterdən çox ola bilməz")]
        public string BlogSlogan { get; set; }

        [Required(ErrorMessage = "Yardımcı Mətn vacibdir")]
        [MaxLength(1000, ErrorMessage = "Yardımcı Mətni 1000 xarakterdən çox ola bilməz")]
        public string SubText { get; set; }

        [Required(ErrorMessage = "Hərəkət yazısı vacibdir")]
        [MaxLength(100, ErrorMessage = "Hərəkət yazısı 100 xarakterdən çox ola bilməz")]
        public string ActionText { get; set; }

        [Required(ErrorMessage = "Link vacibdir")]
        [MaxLength(100, ErrorMessage = "Link 100 xarakterdən çox ola bilməz")]
        public string EndPoint { get; set; }
        public IFormFile File { get; set; }
    }
}
