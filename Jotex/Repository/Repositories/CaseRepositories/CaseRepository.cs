using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.CaseRepositories
{
    public class CaseRepository : ICaseRepository
    {
        private readonly JotexDbContext _context;

        public CaseRepository(JotexDbContext context)
        {
            _context = context;
        }

        public OurAgent CreateAgent(OurAgent model)
        {
            model.AddedDate = DateTime.Now;
            _context.Agents.Add(model);
            _context.SaveChanges();
            return model;
        }

        public CaseStudy CreateCase(CaseStudy model)
        {
            model.AddedDate = DateTime.Now;
            _context.CaseStudies.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteAgent(OurAgent agent)
        {
            _context.Agents.Remove(agent);
            _context.SaveChanges();
        }

        public void DeleteCase(CaseStudy caseStudy)
        {
            _context.CaseStudies.Remove(caseStudy);
            _context.SaveChanges();
        }

        public OurAgent GetAgentById(int id)
        {
            return _context.Agents.Include(s => s.Service).FirstOrDefault(s => s.Id == id); 
        }

        public IEnumerable<OurAgent> GetAllAgents()
        {
            return _context.Agents.Include(a => a.Service).ToList();
        }

        public IEnumerable<CaseStudy> GetAllCases()
        {
            return _context.CaseStudies.ToList();
        }

        public CaseStudy GetCaseById(int id)
        {
            return _context.CaseStudies.Find(id);
        }

        public IEnumerable<CaseStudy> GetCaseStudies()
        {
            return _context.CaseStudies.Include(c=>c.Specs).Where(c => c.Status).ToList();
        }

        public IEnumerable<OurAgent> GetOurAgents()
        {
            return _context.Agents.Where(a => a.Status).Take(3).ToList();
        }

        public IEnumerable<Service> GetServices()
        {
            return _context.Services.Include(s => s.Details).Include(s => s.Specs).Where(s => s.Status).ToList();
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }

        public void UpdateAgent(OurAgent agentToUpdate, OurAgent model)
        {
            agentToUpdate.Status = model.Status;
            agentToUpdate.Name = model.Name;
            agentToUpdate.SurName = model.SurName;
            agentToUpdate.Job = model.Job;
            agentToUpdate.Image = model.Image;
            agentToUpdate.ServiceId = model.ServiceId;
            agentToUpdate.Image = model.Image;
            agentToUpdate.ModifiedBy = model.ModifiedBy;
            agentToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void UpdateCase(CaseStudy caseStudyToUpdate, CaseStudy model)
        {
            caseStudyToUpdate.Status = model.Status;
            caseStudyToUpdate.Title = model.Title;
            caseStudyToUpdate.Detail = model.Detail;
            caseStudyToUpdate.SubDetail = model.SubDetail;
            caseStudyToUpdate.Challenge = model.Challenge;
            caseStudyToUpdate.SubDetail = model.SubDetail;
            caseStudyToUpdate.Image = model.Image;
            caseStudyToUpdate.Solution = model.Solution;
            caseStudyToUpdate.Result = model.Result;
            caseStudyToUpdate.ModifiedBy = model.ModifiedBy;
            caseStudyToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
