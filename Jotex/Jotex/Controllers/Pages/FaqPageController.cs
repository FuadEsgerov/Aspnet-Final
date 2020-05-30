using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.FaqRepository;

namespace Jotex.Controllers.Pages
{
    public class FaqPageController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFaqRepository _faqRepository;
        public FaqPageController(IMapper mapper, IFaqRepository faqRepository)
        {
            _mapper = mapper;
            _faqRepository = faqRepository;
        }

        public IActionResult Index()
        {
            var faqs = _faqRepository.GetFaqs();

            var model = _mapper.Map<IEnumerable<Faq>, IEnumerable<FaqViewModel>>(faqs);

            return View(model);


        }
    }
}
