using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.CaseRepositories;
using Repository.Repositories.ContentRepositories;
using Repository.Repositories.BlogRepositories;

namespace Jotex.Controllers
{
    public class CaseStudyController : Controller
    {
        private readonly ICaseRepository _caseRepository;
        private readonly IContentRepository _contentRepository;
        public CaseStudyController(ICaseRepository caseRepository, IContentRepository contentRepository)
        {
            _caseRepository = caseRepository;
            _contentRepository = contentRepository;
        }
        public IActionResult Index()

        {
            var model = new CaseViewModel
            {
                OurAgents = _contentRepository.GetOurAgents(),
                Services = _contentRepository.GetServices(),
            };
            

            return View(model);
        }
        public IActionResult CaseSingle()
        {
            var model = new CaseViewModel
            {
                Setting = _caseRepository.GetSettings(),

                Services = _caseRepository.GetServices(),
                OurAgents = _caseRepository.GetOurAgents(),
                CaseStudies = _caseRepository.GetCaseStudies()



            };
       
            return View(model);
        }
    }
}