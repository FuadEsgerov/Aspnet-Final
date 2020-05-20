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
        public IEnumerable<Faq> GetFaqs()
        {
            return _context.Faqs.Where(s => s.Status)
                                           .ToList();
        }
        public IEnumerable<Setting>GetSettings()
        {
            return _context.Settings.Where(s => s.Status)
                                           .ToList();
        }

    }
}
