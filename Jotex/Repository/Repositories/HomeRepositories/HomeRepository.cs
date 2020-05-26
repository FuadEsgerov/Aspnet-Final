using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.BlogRepositories
{
   public class HomeRepository:IHomeRepository
    {
        private readonly JotexDbContext _context;

        public HomeRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<About> GetAbouts()
        {
            return _context.Abouts.Where(c => c.Status).ToList();
        }

        public IEnumerable<CoverdAds> GetCoverdAds()
        {
            return _context.CovardAds.Where(c => c.Status).ToList();
        }

        public IEnumerable<Label> GetLabels()
        {
            return _context.Labels.Where(c => c.Status).ToList();
        }

        public IEnumerable<LikeableArea> GetLikeableAreas()
        {
            return _context.LikeableAreas.Where(c => c.Status).ToList();
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }

        public IEnumerable<OurBestPlan> GetOurBestPlans()
        {
            return _context.OurBestPlans.Where(c => c.Status).ToList();
        }

        public IEnumerable<OurBlog> GetOurBlogs()
        {
            return _context.OurBlogs.OrderByDescending(t => t.AddedDate).Take(2).ToList();
        }

        public IEnumerable<Count> GetCounts()
        {
            return _context.Counts.Where(c => c.Status).ToList();
        }
    }
}
