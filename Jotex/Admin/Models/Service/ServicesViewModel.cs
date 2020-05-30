using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Service
{
    public class ServicesViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }

        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Xidmət adı vacibdir")]
        [MaxLength(50, ErrorMessage = "Xidmət adı max 50 xarakter ola bilər")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Xidmət Logosu vacibdir")]
        [MaxLength(100, ErrorMessage = "Xidmət logosu max 100 xarakter ola bilər")]
        public string Logo { get; set; }

        public IList<ServicesDetailViewModel> Details { get; set; }

        public IList<ServiceSpecViewModel> Specs { get; set; }
    }
}
