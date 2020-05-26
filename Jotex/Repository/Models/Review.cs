using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Review:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        
        public int OurBlogId { get; set; }
        public virtual OurBlog OurBlog { get; set; }
    }
}
