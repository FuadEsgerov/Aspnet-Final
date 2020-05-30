using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using Repository.Repositories.HomeRepositories;

namespace Admin.Controllers.HomeAdmin
{

    [TypeFilter(typeof(Auth))]
    public class TestimonialController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IContentRepository _contentRepository;
        private readonly IMapper _mapper;

        public TestimonialController(IContentRepository contentRepository, IMapper mapper)
        {
            _contentRepository = contentRepository;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var testimonials = _contentRepository.GetAllTestimonials();
            var model = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialViewModel>>(testimonials);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TestimonialViewModel testimonial)
        {
            if (ModelState.IsValid)
            {
                Testimonial model = _mapper.Map<TestimonialViewModel, Testimonial>(testimonial);
                model.AddedBy = _admin.Fullname;
                _contentRepository.CreateTestimonial(model);
                return RedirectToAction("index");
            }
            return View(testimonial);
        }



        public IActionResult Edit(int id)
        {
            Testimonial testimonial = _contentRepository.GetTestimonialById(id);
            if (testimonial == null) return NotFound();
            var model = _mapper.Map<Testimonial, TestimonialViewModel>(testimonial);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TestimonialViewModel testimonial)
        {
            if (ModelState.IsValid)
            {
                Testimonial model = _mapper.Map<TestimonialViewModel, Testimonial>(testimonial);
                model.ModifiedBy = _admin.Fullname;
                Testimonial testimonialToUpdate = _contentRepository.GetTestimonialById(testimonial.Id);
                if (testimonialToUpdate == null) return NotFound();
                _contentRepository.UpdateTestimonial(testimonialToUpdate, model);
                return RedirectToAction("index");
            }
            return View(testimonial);
        }
        public IActionResult Delete(int id)
        {
            Testimonial testimonial = _contentRepository.GetTestimonialById(id);
            if (testimonial == null) return NotFound();
            _contentRepository.DeleteTestimonial(testimonial);
            return RedirectToAction("index");
        }

    }
}
