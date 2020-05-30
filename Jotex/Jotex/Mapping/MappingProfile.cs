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
      
           
            CreateMap<ContactUs, ContactUsViewModel>();
            CreateMap<About, AboutViewModel>();
          
            CreateMap<Testimonial, TestimonialViewModel>();
        
            CreateMap<Brand, BrandViewModel>();

            CreateMap<OurBlog, BlogViewModel>();
            CreateMap<OurBlog, OurBlogViewModel>();
            CreateMap<Review, OurBlogViewModel>();
            CreateMap<Review, ReviewViewModel>();
            CreateMap<Faq, FaqViewModel>();


        }
    }
}
