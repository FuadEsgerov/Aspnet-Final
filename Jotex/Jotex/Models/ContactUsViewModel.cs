using Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class ContactUsViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(200)]

        public string Description { get; set; }
        [Required]
        public ContactSubject Subject { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
    }
}
