using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models.Blog
{
    public class BlogViewModel
    {
        public IEnumerable<OurBlog> OurBlogs { get; set; }
    }       
}
