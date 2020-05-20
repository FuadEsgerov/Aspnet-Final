using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class OurAgent:BaseEntity
    {
        [Required]
        public int AboutUsId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string SurName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Job { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public About AboutUs { get; set; }

    }
}
