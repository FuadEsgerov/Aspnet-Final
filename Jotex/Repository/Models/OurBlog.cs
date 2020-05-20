using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class OurBlog:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Tag { get; set; }
       
        [MaxLength(100)]
        public string Image { get; set; }
      
        [MaxLength(100)]
        public string Video { get; set; }
        [Required]
        [MaxLength(100)]
        public string EndPoint { get; set; }

    }
}
