using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
   public class OurBlog:BaseEntity
    {
   

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Tag { get; set; }
       
        [MaxLength(100)]
        public string Image { get; set; }
      
        [MaxLength(100)]
        public string Video { get; set; }
        [Required]
        [MaxLength(200)]
        public string SubTitle { get; set; }
        [Required]
        [MaxLength(400)]
        public string BlogSlogan { get; set; }

        [Required]
        [MaxLength(1000)]
        public string SubText { get; set; }
       
        [MaxLength(100)]
        public string ActionText { get; set; }
   
        [MaxLength(100)]
        public string EndPoint { get; set; }
        public ICollection<Review> Reviews { get; set; }
 


    }
}
