using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using Repository.Repositories.FaqRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
    public class FaqViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IFaqRepository _faqRepository;

        public FaqViewComponent(IMapper mapper,
                                   IFaqRepository faqRepository)
        {
            _mapper = mapper;
            _faqRepository = faqRepository;
        }
        
        public IViewComponentResult Invoke()
        {
            var faq = _faqRepository.GetFaqs();

            var model = _mapper.Map<IEnumerable<Faq>, IEnumerable<FaqViewModel>>(faq);

            return View(model);
        }
    }
}
