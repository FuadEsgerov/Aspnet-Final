using AutoMapper;
using Jotex.Models;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
           
            CreateMap <SliderItem, SliderItemViewModel>();
            CreateMap<Faq, FaqViewModel>();
            CreateMap<Setting, SettingViewModel>();

        }
    }
}
