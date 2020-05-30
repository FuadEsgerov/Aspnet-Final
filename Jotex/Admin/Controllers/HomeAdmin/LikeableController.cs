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
    public class LikeableController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;

        public LikeableController(IHomeRepository homeRepository, IMapper mapper)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;

        }


        public IActionResult Index()
        {
            var areas = _homeRepository.GetAllAreas();
            var model = _mapper.Map<IEnumerable<LikeableArea>, IEnumerable<LikeableViewModel>>(areas);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LikeableViewModel areas)
        {

            if (ModelState.IsValid)
            {
                LikeableArea model = _mapper.Map<LikeableViewModel, LikeableArea>(areas);

                model.AddedBy = _admin.Fullname;
                _homeRepository.CreateArea(model);
                return RedirectToAction("index");
            }
            return View(areas);

        }

        public IActionResult Edit(int id)
        {
            LikeableArea areas = _homeRepository.GetAreaById(id);
            if (areas == null) return NotFound();
            var model = _mapper.Map<LikeableArea, LikeableViewModel>(areas);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LikeableViewModel areas)
        {
            if (areas == null) return NotFound();

            if (ModelState.IsValid)
            {
                LikeableArea model = _mapper.Map<LikeableViewModel, LikeableArea>(areas);
                model.ModifiedBy = _admin.Fullname;
                model.ModifiedDate = DateTime.Now;

                LikeableArea areaToUpdate = _homeRepository.GetAreaById(areas.Id);
                if (areaToUpdate == null) return NotFound();
                _homeRepository.UpdateArea(areaToUpdate, model);
                return RedirectToAction("index");
            }
            return View(areas);
        }


        public IActionResult Delete(int id)
        {
            LikeableArea area = _homeRepository.GetAreaById(id);
            if (area == null) return NotFound();
            _homeRepository.DeleteArea(area);
            return RedirectToAction("index");
        }
    }
}
