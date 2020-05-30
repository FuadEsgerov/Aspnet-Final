using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers.ServiceAdmin
{
    [TypeFilter(typeof(Auth))]
    public class ServicesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IContentRepository _contentRepository;
        private readonly IMapper _mapper;

        public ServicesController(IContentRepository contentRepository, IMapper mapper)
        {
            _contentRepository = contentRepository;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var services = _contentRepository.GetAllServices();
            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<ServicesViewModel>>(services);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServicesViewModel services)
        {
            if (ModelState.IsValid)
            {
                Service model = _mapper.Map<ServicesViewModel, Service>(services);
                model.AddedBy = _admin.Fullname;
                _contentRepository.CreateService(model);
                return RedirectToAction("index");
            }
            return View(services);
        }



        public IActionResult Edit(int id)
        {
            Service service = _contentRepository.GetServiceById(id);
            if (service == null) return NotFound();
            var model = _mapper.Map<Service, ServicesViewModel>(service);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServicesViewModel services)
        {
            if (ModelState.IsValid)
            {
                Service model = _mapper.Map<ServicesViewModel, Service>(services);
                model.ModifiedBy = _admin.Fullname;
                Service serviceToUpdate = _contentRepository.GetServiceById(services.Id);
                if (serviceToUpdate == null) return NotFound();
                _contentRepository.UpdateService(serviceToUpdate, model);
                return RedirectToAction("index");
            }
            return View(services);
        }
        public IActionResult Delete(int id)
        {
            Service service = _contentRepository.GetServiceById(id);
            if (service == null) return NotFound();
            _contentRepository.DeleteService(service);
            return RedirectToAction("index");
        }
    }
}
