using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Libs;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using Repository.Services;

namespace Admin.Controllers.BlogAdmin
{
    [TypeFilter(typeof(Auth))]
    public class BlogsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IContentRepository _contentRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        private readonly ICloudinaryService _cloudinaryService;
       

        public BlogsController(ICloudinaryService cloudinaryService, IContentRepository contentRepository, IMapper mapper, IFileManager fileManager)
        {
            _contentRepository = contentRepository;
            _mapper = mapper;
            _fileManager = fileManager;
            _cloudinaryService = cloudinaryService;
        }
        public IActionResult Index()
        {
            var blogs = _contentRepository.GetAllBlogs();
            var model = _mapper.Map<IEnumerable<OurBlog>, IEnumerable<BlogViewModel>>(blogs);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogViewModel blog)
        {
            if (ModelState.IsValid)
            {
                OurBlog model = _mapper.Map<BlogViewModel, OurBlog>(blog);
                model.AddedBy = _admin.Fullname;
                _contentRepository.CreateBlog(model);
                return RedirectToAction("index");
            }
            return View(blog);
        }



        public IActionResult Edit(int id)
        {
            OurBlog blog = _contentRepository.GetBlogById(id);
            if (blog == null) return NotFound();
            var model = _mapper.Map<OurBlog, BlogViewModel>(blog);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogViewModel blog)
        {
            if (ModelState.IsValid)
            {
                OurBlog model = _mapper.Map<BlogViewModel, OurBlog>(blog);
                model.ModifiedBy = _admin.Fullname;
                OurBlog blogToUpdate = _contentRepository.GetBlogById(blog.Id);
                if (blogToUpdate == null) return NotFound();
            
                _contentRepository.UpdateBlog(blogToUpdate, model);
                return RedirectToAction("index");
            }
            return View(blog);
        }
        public IActionResult Delete(int id)
        {
            OurBlog blog = _contentRepository.GetBlogById(id);
            if (blog == null) return NotFound();
            _contentRepository.DeleteBlog(blog);
            return RedirectToAction("index");
        }
        [HttpPost]
        public IActionResult Upload(IFormFile file, int? blogId)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);

            if (blogId != null)
            {
                OurBlog blogPhoto = new OurBlog
                {
                    AddedBy = _admin.Fullname,
                    AddedDate = DateTime.Now,
                    Image = publicId,
                   
                  
                };
                _contentRepository.AddPhoto(blogPhoto);
            }

            return Ok(new
            {
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        [HttpPost]
        public IActionResult Remove(string name, int? id)
        {
            if (id != null)
            {
                _contentRepository.RemovePhotoById((int)id);
            }

            _cloudinaryService.Delete(name);

            return Ok(new { status = 200 });
        }
    }
}
