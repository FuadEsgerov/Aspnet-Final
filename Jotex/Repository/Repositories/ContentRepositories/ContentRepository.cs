using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
   public class ContentRepository:IContentRepository
    {
        private readonly JotexDbContext _context;

        public ContentRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                           .ToList();
        }
   
        public IEnumerable<Setting>GetSettings()
        {
            return _context.Settings.Where(s => s.Status)
                                           .ToList();
        }

        public IEnumerable<About> GetAbout()
        {
            return _context.Abouts.Where(s => s.Status)
                                        .ToList();
        }

        public IEnumerable<LikeableArea> GetLikeableArea()
        {
            return _context.LikeableAreas.Where(s => s.Status)
                .ToList();
        }

        public IEnumerable<OurBestPlan> GetOurBestPlans()
        {
            return _context.OurBestPlans.Include("Label").Where(s => s.Status)
                .ToList();
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.OrderByDescending(t => t.AddedDate).ToList();
        }

        public IEnumerable<CoverdAds> GetCoverdAds()
        {
            return _context.CovardAds.Where(s => s.Status)
               .ToList();
        }
    }
}
