
using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System.Collections.Generic;

namespace Jotex.Controllers
{
    public class BlogController : Controller

    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;


        public BlogController(IContentRepository contentRepository, IMapper mapper)
        {

            _mapper = mapper;
            _contentRepository = contentRepository;

        }


        public IActionResult Index(BlogSeachViewModel blogSearch)
        {
            var blogs = _contentRepository.GetOurBlogs(blogSearch.Limit,
                                                                     (blogSearch.Page - 1) * blogSearch.Limit);
           
            var model = new BlogViewModel
            {
                OurBlogs = _mapper.Map<IEnumerable<OurBlog>, IEnumerable<OurBlogViewModel>>(blogs),
                Services = _contentRepository.GetServices(),
               

                Page = blogSearch.Page,
                Limit = blogSearch.Limit,
                Count = blogSearch.Count,
            };

            return View(model);
        }
        public IActionResult Detailed(int id)

        {
            var blogfind = _contentRepository.FindOurBlogs(id);
            var addreview = _contentRepository.GetReviews(id);


            var model = new BlogViewModel
            {
                OurBlogs = _mapper.Map<IEnumerable<OurBlog>, IEnumerable<OurBlogViewModel>>(blogfind),
                Reviews = _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewViewModel>>(addreview),
                Services=_contentRepository.GetServices(),
                Setting = _contentRepository.GetSettings(),
            };
            
            return View(model);
        }
       
  
        }
}