using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.BlogRepositories;

namespace Jotex.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutRepository _aboutRepository;
        public AboutController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
         
        }
        public IActionResult Index()
        {
            var model = new AboutViewModel
            {
                Abouts = _aboutRepository.GetAbouts(),
                Settings = _aboutRepository.GetSettings(),
                Agents = _aboutRepository.GetOurAgents(),
            };
            return View(model);
        }
    }
}