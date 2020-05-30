using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.HomeRepositories;

namespace Admin.Controllers.HomeAdmin
{
    [TypeFilter(typeof(Auth))]
    public class SliderController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;

        public SliderController(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;

        }


        public IActionResult Index()
        {
            var homeslider = _homeRepository.GetSliders();
            var model = _mapper.Map<IEnumerable<SliderItem>, IEnumerable<SliderViewModel>>(homeslider);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SliderViewModel slider)
        {

            if (ModelState.IsValid)
            {
                SliderItem model = _mapper.Map<SliderViewModel, SliderItem>(slider);

                model.AddedBy = _admin.Fullname;
                _homeRepository.CreateSlider(model);
                return RedirectToAction("index");
            }
            return View(slider);

        }
       
        public IActionResult Edit(int id)
        {
            SliderItem slider = _homeRepository.GetSliderById(id);
            if (slider == null) return NotFound();
            var model = _mapper.Map<SliderItem, SliderViewModel>(slider);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SliderViewModel slider)
        {
            if (slider == null) return NotFound();

            if (ModelState.IsValid)
            {
                SliderItem model = _mapper.Map<SliderViewModel, SliderItem>(slider);
                model.ModifiedBy = _admin.Fullname;
                model.ModifiedDate = DateTime.Now;

                SliderItem sliderToUpdate = _homeRepository.GetSliderById(slider.Id);
                if (sliderToUpdate == null) return NotFound();
                _homeRepository.UpdateSlider(sliderToUpdate, model);
                return RedirectToAction("index");
            }
            return View(slider);
        }


        public IActionResult Delete(int id)
        {
            SliderItem slider = _homeRepository.GetSliderById(id);
            if (slider == null) return NotFound();
            _homeRepository.DeleteSlider(slider);
            return RedirectToAction("index");
        }
    }
}
