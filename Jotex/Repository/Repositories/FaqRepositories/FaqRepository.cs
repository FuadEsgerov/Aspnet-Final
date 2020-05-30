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

        public Faq CreateFaq(Faq model)
        {
            model.AddedDate = DateTime.Now;
            _context.Faqs.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteFaq(Faq faq)
        {
            _context.Faqs.Remove(faq);
            _context.SaveChanges();
        }

        public IEnumerable<Faq> GetAllFaqs()
        {
            return _context.Faqs.ToList();
        }

        public Faq GetFaqById(int id)
        {
            return _context.Faqs.Find(id);
        }

        public IEnumerable<Faq> GetFaqs()
        {
            return _context.Faqs.Where(f => f.Status)
                                        .ToList();
        }

        public void UpdateFaq(Faq faqToUpdate, Faq model)
        {
            faqToUpdate.Status = model.Status;
            faqToUpdate.Question = model.Question;
            faqToUpdate.Answer = model.Answer;
            faqToUpdate.ModifiedBy = model.ModifiedBy;
            faqToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
