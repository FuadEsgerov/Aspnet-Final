using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers.ServiceAdmin
{
    [TypeFilter(typeof(Auth))]
    public class ServiceDetailController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IContentRepository _contentRepository;
        private readonly IMapper _mapper;

        public ServiceDetailController(IContentRepository contentRepository, IMapper mapper)
        {
            _contentRepository = contentRepository;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var details = _contentRepository.GetAllServiceDetail();
            var model = _mapper.Map<IEnumerable<ServiceDetail>, IEnumerable<ServicesDetailViewModel>>(details);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Services = _contentRepository.GetAllServices();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServicesDetailViewModel details)
        {
            ViewBag.Services = _contentRepository.GetAllServices();
            if (ModelState.IsValid)
            {
                ServiceDetail model = _mapper.Map<ServicesDetailViewModel, ServiceDetail>(details);
                model.AddedBy = _admin.Fullname;
            
                _contentRepository.CreateServiceDetail(model);
                return RedirectToAction("index");
            }
            return View(details);
        }



        public IActionResult Edit(int id)
        {
            ViewBag.Services = _contentRepository.GetAllServices();
        
            ServiceDetail details = _contentRepository.GetServiceDetailById(id);
            if (details == null) return NotFound();
            var model = _mapper.Map<ServiceDetail, ServicesDetailViewModel>(details);
          

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServicesDetailViewModel details)
        {
            ViewBag.Services = _contentRepository.GetAllServices();
            if (ModelState.IsValid)
            {
                ServiceDetail model = _mapper.Map<ServicesDetailViewModel, ServiceDetail>(details);
                model.ModifiedBy = _admin.Fullname;
                ServiceDetail serviceDetailToUpdate = _contentRepository.GetServiceDetailById(details.Id);
                if (serviceDetailToUpdate == null) return NotFound();
                _contentRepository.UpdateServiceDetail(serviceDetailToUpdate, model);
                return RedirectToAction("index");
            }
         
            return View(details);
        }
        public IActionResult Delete(int id)
        {
            ServiceDetail details = _contentRepository.GetServiceDetailById(id);
            if (details == null) return NotFound();
            _contentRepository.DeleteServiceDetail(details);
            return RedirectToAction("index");
        }
    }
}
