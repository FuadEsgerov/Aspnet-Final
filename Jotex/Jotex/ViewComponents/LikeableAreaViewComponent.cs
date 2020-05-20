﻿using AutoMapper;
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
    public class LikeableAreaViewComponent:ViewComponent
    {

        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public LikeableAreaViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var likeableArea = _contentRepository.GetLikeableArea();

            var model = _mapper.Map<IEnumerable<LikeableArea>, IEnumerable<LikeableAreaViewModel>>(likeableArea);

            return View(model);
        }
    }
}
