using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.FaqRepository
{
    public interface IFaqRepository
    {
        IEnumerable<Faq> GetFaqs();
    }
}
