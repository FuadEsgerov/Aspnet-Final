using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class LikeableAreaViewModel
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Information { get; set; }
        [Required]
        [MaxLength(50)]
        public string CallUs { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }
        [Required]
        [MaxLength(150)]

        public string Video { get; set; }
        [Required]
        [MaxLength(100)]
        public string Phote { get; set; }
        [Required]
        [MaxLength(50)]
        public int Year { get; set; }
        [Required]
        [MaxLength(50)]
        public string Experience { get; set; }
    }
}
