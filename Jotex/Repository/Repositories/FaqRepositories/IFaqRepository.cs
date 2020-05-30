using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.FaqRepository
{
    public interface IFaqRepository
    {
        IEnumerable<Faq> GetFaqs();
        IEnumerable<Faq> GetAllFaqs();
        Faq CreateFaq(Faq model);
        Faq GetFaqById(int id);
        void UpdateFaq(Faq faqToUpdate, Faq model);
        void DeleteFaq(Faq faq);
    }
}
