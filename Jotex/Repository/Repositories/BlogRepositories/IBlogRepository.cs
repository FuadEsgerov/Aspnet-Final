using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.BlogRepositories
{
   public interface IBlogRepository
    {
        IEnumerable<OurBlog> GetOurBlogs();
    }
}
