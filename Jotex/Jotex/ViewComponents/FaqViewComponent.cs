using AutoMapper;
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
    public class FaqViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public FaqViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }
        
        public IViewComponentResult Invoke()
        {
            var faq = _contentRepository.GetFaqs();

            var model = _mapper.Map<IEnumerable<Faq>, IEnumerable<FaqViewModel>>(faq);

            return View(model);
        }
    }
}
