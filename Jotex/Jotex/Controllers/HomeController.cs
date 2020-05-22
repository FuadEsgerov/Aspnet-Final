using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Jotex.Models;
using Jotex.Models.Blog;
using Repository.Repositories.HomeRepositories;


namespace Jotex.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHomeRepository _homeRepository;
        public HomeController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
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
                 Counts = _homeRepository.GetCounts()



            };
            return View(model);



           
        }

        
    }
}
