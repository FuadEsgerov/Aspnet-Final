using AutoMapper;
using Jotex.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.ViewComponents
{
    public class BrandViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public BrandViewComponent(IMapper mapper,
                                  IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var brand = _contentRepository.GetBrands();

            var model = _mapper.Map<IEnumerable<Brand>, IEnumerable<BrandViewModel>>(brand);

            return View(model);
        }
    }
}
