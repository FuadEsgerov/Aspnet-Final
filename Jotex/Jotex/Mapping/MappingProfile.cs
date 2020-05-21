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
            CreateMap<ContactUs, ContactUsViewModel>();
            CreateMap<About, AboutViewModel>();
            CreateMap<LikeableArea, LikeableAreaViewModel>();
            CreateMap<OurBestPlan, OurBestPlanViewModel>();
            CreateMap<Label, LabelViewModel>();
            CreateMap<Testimonial, TestimonialViewModel>();
            CreateMap<OurBlog, OurBlogViewModel>();
            CreateMap<CoverdAds, CoverAdsViewModel>();

        }
    }
}
