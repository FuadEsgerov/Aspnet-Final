using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class About : BaseEntity
    {

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone{ get; set; }
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
