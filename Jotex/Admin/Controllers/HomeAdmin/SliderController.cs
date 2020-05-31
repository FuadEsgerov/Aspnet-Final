using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Libs;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.HomeRepositories;
using Repository.Services;

namespace Admin.Controllers.HomeAdmin
{
    [TypeFilter(typeof(Auth))]
    public class SliderController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        private readonly ICloudinaryService _cloudinaryService;

        public SliderController(ICloudinaryService cloudinaryService, IHomeRepository homeRepository, IMapper mapper,IFileManager fileManager)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
            _fileManager = fileManager;
            _cloudinaryService = cloudinaryService;

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
        [HttpPost]
        public IActionResult Upload(IFormFile file, int? sliderId)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);

            if (sliderId != null)
            {
                SliderItem slidePhoto = new SliderItem
                {
                    AddedBy = _admin.Fullname,
                    AddedDate = DateTime.Now,
                    Image = publicId,


                };
                _homeRepository.AddPhoto(slidePhoto);
            }

            return Ok(new
            {
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        [HttpPost]
        public IActionResult Remove(string name, int? id)
        {
            if (id != null)
            {
                _homeRepository.RemovePhotoById((int)id);
            }

            _cloudinaryService.Delete(name);

            return Ok(new { status = 200 });
        }
    }
}
