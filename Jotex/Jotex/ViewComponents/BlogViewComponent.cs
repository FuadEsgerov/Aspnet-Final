using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.BlogRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
    public class BlogViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;

        public BlogViewComponent(IMapper mapper,
                                   IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }
        public IViewComponentResult Invoke()
        {
            var blog = _blogRepository.GetOurBlogs();

            var model = _mapper.Map<IEnumerable<OurBlog>, IEnumerable<OurBlogViewModel>>(blog);

            return View(model);
        }
    }
}
