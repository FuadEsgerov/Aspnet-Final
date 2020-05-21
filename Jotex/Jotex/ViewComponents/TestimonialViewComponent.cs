using AutoMapper;
using Jotex.Mapping;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
    public class TestimonialViewComponent : ViewComponent
    {
        private IMapper _mapper;
        private IContentRepository _contentRepository;

        public TestimonialViewComponent(IMapper mapper,
                                IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var testimonial = _contentRepository.GetTestimonials();

            var model = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialViewModel>>(testimonial);

            return View(model);
        }
    }
}
