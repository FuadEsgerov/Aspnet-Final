using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Setting:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(100)]
        public string CoverImage { get; set; }

        [Required]
        [MaxLength(50)]
        public string NeedHelpNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string WorkTime { get; set; }

        public IEnumerable<SocialMediaAccount> Accounts { get; set; }
    }
}
