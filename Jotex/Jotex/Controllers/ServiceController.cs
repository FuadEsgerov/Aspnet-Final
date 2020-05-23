using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContentRepositories;

namespace Jotex.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IContentRepository _contentRepository;
        
        public ServiceController(IContentRepository contentRepository)
        {
           
            _contentRepository = contentRepository;
        }
        public IActionResult Index()
        {
            var model = new ServiceViewModel
            {
                Services = _contentRepository.GetServices()
            };
            return View(model);
        }
    }
}