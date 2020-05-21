using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly JotexDbContext _context;

        public BlogRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<OurBlog> GetOurBlogs()
        {
            return _context.OurBlogs.OrderByDescending(t => t.AddedDate).ToList(); 
        }
    }
}
