using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContactRepositories
{
   public interface IContactRepository
    {
        IEnumerable<ContactUs> GetContactUs();
    }
}
