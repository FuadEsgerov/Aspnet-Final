﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class OurBlogViewModel
    {
        public BaseEntityViewModel BaseEntity { get; set; }
        public string Title { get; set; }
      
        public string Text { get; set; }
      
        public string Tag { get; set; }

     
        public string Image { get; set; }

       
        public string Video { get; set; }
       
        public string EndPoint { get; set; }
    }
}