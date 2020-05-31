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
using Repository.Repositories.AboutRepositories;
using Repository.Services;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AboutUsController : Controller
    {             
            private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
            private readonly IMapper _mapper;
            private readonly IAboutRepository _aboutRepository;
        private readonly IFileManager _fileManager;
        private readonly ICloudinaryService _cloudinaryService;
        public AboutUsController(IMapper mapper, IAboutRepository aboutRepository, ICloudinaryService cloudinaryService, IFileManager fileManager)
            {
                _mapper = mapper;
                _aboutRepository = aboutRepository;
            _fileManager = fileManager;
            _cloudinaryService = cloudinaryService;
        }
            public IActionResult Index()
            {
                var abouts = _aboutRepository.GetAllAbouts();
                var model = _mapper.Map<IEnumerable<About>, IEnumerable<AboutUsViewModel>>(abouts);
                return View(model);
            }
            public IActionResult Create()
            {

                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Create(AboutUsViewModel about)
            {
                if (ModelState.IsValid)
                {
                    About model = _mapper.Map<AboutUsViewModel, About>(about);
                    model.AddedBy = _admin.Fullname;
                    _aboutRepository.CreateAbout(model);
                    return RedirectToAction("index");
                }
                return View(about);
            }



            public IActionResult Edit(int id)
            {
                About about = _aboutRepository.GetAboutById(id);
                if (about == null) return NotFound();
                var model = _mapper.Map<About, AboutUsViewModel>(about);
                return View(model);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Edit(AboutUsViewModel about)
            {
                if (ModelState.IsValid)
                {
                    About model = _mapper.Map<AboutUsViewModel, About>(about);
                    model.ModifiedBy = _admin.Fullname;
                    About aboutToUpdate = _aboutRepository.GetAboutById(about.Id);
                    if (aboutToUpdate == null) return NotFound();
                    _aboutRepository.UpdateAbout(aboutToUpdate, model);
                    return RedirectToAction("index");
                }
                return View(about);
            }
            public IActionResult Delete(int id)
            {
                About about = _aboutRepository.GetAboutById(id);
                if (about == null) return NotFound();
                _aboutRepository.DeleteAbout(about);
                return RedirectToAction("index");
            }
        [HttpPost]
        public IActionResult Upload(IFormFile file, int? aboutId)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);

            if (aboutId != null)
            {
                About aboutPhoto = new About
                {
                    AddedBy = _admin.Fullname,
                    AddedDate = DateTime.Now,
                    Image = publicId,


                };
                _aboutRepository.AddPhoto(aboutPhoto);
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
                _aboutRepository.RemovePhotoById((int)id);
            }

            _cloudinaryService.Delete(name);

            return Ok(new { status = 200 });
        }

    }
    }
