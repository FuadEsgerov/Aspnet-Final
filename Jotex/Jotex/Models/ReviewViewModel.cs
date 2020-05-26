using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class ReviewViewModel
    {
        
        public string Username { get; set; }
        
        public string Email { get; set; }
      
        public string Text { get; set; }
  

        public int OurBlogId { get; set; }
        public virtual OurBlog OurBlog { get; set; }
    }
}
