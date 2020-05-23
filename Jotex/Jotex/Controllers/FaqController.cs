using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.FaqRepository;
using Repository.Repositories.HomeRepositories;

namespace Jotex.Controllers
{
    public class FaqController : Controller
    {
        private readonly IFaqRepository _faqRepository;
       

        public FaqController(IFaqRepository faqRepository)
        {
       
          
            _faqRepository = faqRepository;
        }

        public IActionResult Index()
        {
            var model = new FaqViewModel
            {
                Faqs = _faqRepository.GetFaqs(),
               


            };

            return View(model);
        }
    }
}