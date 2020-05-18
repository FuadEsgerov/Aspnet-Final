using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class Slider:BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Slogan  { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }

    }

}
