using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System.Collections.Generic;

namespace Jotex.ViewComponents
{
    public class AboutViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public AboutViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var about = _contentRepository.GetAbout();

            var model = _mapper.Map<IEnumerable<About>, IEnumerable<AboutViewModel>>(about);

            return View(model);
        }
    }
}
