using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.AboutRepositories;


namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AboutUsController : Controller
    {             
            private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
            private readonly IMapper _mapper;
            private readonly IAboutRepository _aboutRepository;
            public AboutUsController(IMapper mapper, IAboutRepository aboutRepository)
            {
                _mapper = mapper;
                _aboutRepository = aboutRepository;
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

        }
    }
