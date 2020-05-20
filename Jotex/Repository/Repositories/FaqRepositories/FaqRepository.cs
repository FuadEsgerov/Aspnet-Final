using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.FaqRepository
{
    public class FaqRepository : IFaqRepository
    {
        private readonly JotexDbContext _context;

        public FaqRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Faq> GetFaqs()
        {
            return _context.Faqs.Where(f => f.Status)
                                        .ToList();
        }
    }
}
