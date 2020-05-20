using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContactRepositories
{
    public class ContactRepository:IContactRepository
    {
        private readonly JotexDbContext _context;

        public ContactRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ContactUs> GetContactUs()
        {
            return _context.ContactUs.Where(s => s.Status)
                                           .ToList();
        }
    }
    }

