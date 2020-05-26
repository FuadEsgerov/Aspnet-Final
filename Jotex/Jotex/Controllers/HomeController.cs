using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jotex.Models;

using Repository.Repositories.BlogRepositories;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHomeRepository _homeRepository;
        private readonly IContentRepository _contentRepository;
        public HomeController(IHomeRepository homeRepository,IContentRepository contentRepository)
        {
            _homeRepository = homeRepository;
            _contentRepository = contentRepository;
        }


        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Abouts = _homeRepository.GetAbouts(),
                Settings = _homeRepository.GetSettings(),
                CoverdAds = _homeRepository.GetCoverdAds(),
                LikeableAreas = _homeRepository.GetLikeableAreas(),
                OurBestPlans = _homeRepository.GetOurBestPlans(),
                Labels = _homeRepository.GetLabels(),
                OurBlogs = _homeRepository.GetOurBlogs(),
                 Counts = _homeRepository.GetCounts(),
                 Services=_contentRepository.GetServices()



            };
            return View(model);



           
        }

        
    }
}
