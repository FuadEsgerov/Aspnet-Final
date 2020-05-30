using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.FaqRepository;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class FaqController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IFaqRepository _faqRepository;
        public FaqController(IMapper mapper, IFaqRepository faqRepository)
        {
            _mapper = mapper;
            _faqRepository = faqRepository;
        }
        public IActionResult Index()
        {
            var faqs = _faqRepository.GetAllFaqs();
            var model = _mapper.Map<IEnumerable<Faq>, IEnumerable<FaqViewModel>>(faqs);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FaqViewModel faq)
        {
            if (ModelState.IsValid)
            {
                Faq model = _mapper.Map<FaqViewModel, Faq>(faq);
                model.AddedBy = _admin.Fullname;
                _faqRepository.CreateFaq(model);
                return RedirectToAction("index");
            }
            return View(faq);
        }

     

        public IActionResult Edit(int id)
        {
            Faq faq = _faqRepository.GetFaqById(id);
            if (faq == null) return NotFound();
            var model = _mapper.Map<Faq, FaqViewModel>(faq);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FaqViewModel faq)
        {
            if (ModelState.IsValid)
            {
                Faq model = _mapper.Map<FaqViewModel, Faq>(faq);
                model.ModifiedBy = _admin.Fullname;
                Faq fagToUpdate = _faqRepository.GetFaqById(faq.Id);
                if (fagToUpdate == null) return NotFound();
                _faqRepository.UpdateFaq(fagToUpdate, model);
                return RedirectToAction("index");
            }
            return View(faq);
        }
        public IActionResult Delete(int id)
        {
            Faq faq = _faqRepository.GetFaqById(id);
            if (faq == null) return NotFound();
            _faqRepository.DeleteFaq(faq);
            return RedirectToAction("index");
        }

    }
}
