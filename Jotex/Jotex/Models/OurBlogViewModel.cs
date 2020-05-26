using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class OurBlogViewModel:BaseEntity
    {
        
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string SubText { get; set; }

        public string Text { get; set; }
     
        public string Tag { get; set; }

   
        public string Image { get; set; }

        public string Video { get; set; }
      
        public string ActionText { get; set; }
       
        public string EndPoint { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
