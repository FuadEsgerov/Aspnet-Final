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
    }
}
