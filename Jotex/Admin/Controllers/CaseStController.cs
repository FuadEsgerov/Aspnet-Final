using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.CaseRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class CaseStController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly ICaseRepository _caseRepository;
        public CaseStController(IMapper mapper, ICaseRepository caseRepository)
        {
            _mapper = mapper;
            _caseRepository = caseRepository;
        }
        public IActionResult Index()
        {
            var cases = _caseRepository.GetAllCases();
            var model = _mapper.Map<IEnumerable<CaseStudy>, IEnumerable<CaseViewModel>>(cases);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CaseViewModel cases)
        {
            if (ModelState.IsValid)
            {
                CaseStudy model = _mapper.Map<CaseViewModel, CaseStudy>(cases);
                model.AddedBy = _admin.Fullname;
                _caseRepository.CreateCase(model);
                return RedirectToAction("index");
            }
            return View(cases);
        }



        public IActionResult Edit(int id)
        {
            CaseStudy cases = _caseRepository.GetCaseById(id);
            if (cases == null) return NotFound();
            var model = _mapper.Map<CaseStudy, CaseViewModel>(cases);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CaseViewModel cases)
        {
            if (ModelState.IsValid)
            {
                CaseStudy model = _mapper.Map<CaseViewModel, CaseStudy>(cases);
                model.ModifiedBy = _admin.Fullname;
                CaseStudy caseStudyToUpdate = _caseRepository.GetCaseById(cases.Id);
                if (caseStudyToUpdate == null) return NotFound();
                _caseRepository.UpdateCase(caseStudyToUpdate, model);
                return RedirectToAction("index");
            }
            return View(cases);
        }
        public IActionResult Delete(int id)
        {
            CaseStudy cases = _caseRepository.GetCaseById(id);
            if (cases == null) return NotFound();
            _caseRepository.DeleteCase(cases);
            return RedirectToAction("index");
        }
    }
}
