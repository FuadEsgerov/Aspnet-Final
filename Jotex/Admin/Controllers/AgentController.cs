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
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class AgentController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICaseRepository _caseRepository;
        private readonly IContentRepository _contentRepository;
        private readonly IMapper _mapper;

        public AgentController(ICaseRepository caseRepository, IContentRepository contentRepository, IMapper mapper)
        {
            _caseRepository = caseRepository;
            _contentRepository = contentRepository;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var details = _caseRepository.GetAllAgents();
            var model = _mapper.Map<IEnumerable<OurAgent>, IEnumerable<AgentViewModel>>(details);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Services = _contentRepository.GetAllServices();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AgentViewModel agents)
        {
            ViewBag.Services = _contentRepository.GetAllServices();
            if (ModelState.IsValid)
            {
                OurAgent model = _mapper.Map<AgentViewModel, OurAgent>(agents);
                model.AddedBy = _admin.Fullname;

                _caseRepository.CreateAgent(model);
                return RedirectToAction("index");
            }
            return View(agents);
        }



        public IActionResult Edit(int id)
        {
            ViewBag.Services = _contentRepository.GetAllServices();

            OurAgent agents = _caseRepository.GetAgentById(id);
            if (agents == null) return NotFound();
            var model = _mapper.Map<OurAgent, AgentViewModel>(agents);


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AgentViewModel agents)
        {
            ViewBag.Services = _contentRepository.GetAllServices();
            if (ModelState.IsValid)
            {
                OurAgent model = _mapper.Map<AgentViewModel, OurAgent>(agents);
                model.ModifiedBy = _admin.Fullname;
                OurAgent agentToUpdate = _caseRepository.GetAgentById(agents.Id);
                if (agentToUpdate == null) return NotFound();
                _caseRepository.UpdateAgent(agentToUpdate, model);
                return RedirectToAction("index");
            }

            return View(agents);
        }
        public IActionResult Delete(int id)
        {
            OurAgent agents = _caseRepository.GetAgentById(id);
            if (agents == null) return NotFound();
            _caseRepository.DeleteAgent(agents);
            return RedirectToAction("index");
        }
    }
}
