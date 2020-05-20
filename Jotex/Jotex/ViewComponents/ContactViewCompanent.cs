using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContactRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
    public class ContactViewCompanent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContactRepository _contactRepository;

        public ContactViewCompanent(IMapper mapper,
                                   IContactRepository contactRepository)
        {
            _mapper = mapper;
            _contactRepository = contactRepository;
        }

        public IViewComponentResult Invoke()
        {
            var contactUs = _contactRepository.GetContactUs();

            var model = _mapper.Map<IEnumerable<ContactUs>, IEnumerable<ContactUsViewModel>>(contactUs);

            return View(model);
        }
    }
}
