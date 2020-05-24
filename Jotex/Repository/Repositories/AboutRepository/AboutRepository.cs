using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.BlogRepositories
{
    public class AboutRepository : IAboutRepository
    {
        private readonly JotexDbContext _context;

        public AboutRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OurAgent> GetOurAgents()
        {
            return _context.Agents.Where(a => a.Status).Take(7).ToList();
        }

        public IEnumerable<About> GetAbouts()
        {
            return _context.Abouts.Where(a => a.Status).ToList(); 
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }
    }
}
