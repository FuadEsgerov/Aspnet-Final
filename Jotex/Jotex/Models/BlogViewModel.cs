using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class BlogViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public Setting Setting { get; set; }
        public IEnumerable<OurBlogViewModel> OurBlogs { get; set; }
        public IEnumerable<ReviewViewModel> Reviews { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
    public class BlogSeachViewModel 
    {
        public BlogSeachViewModel()
        { Page = 1;
            Limit = 8;
            Count = 20;
        }
        public int Id { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public int Count { get; set; }



    }
}
