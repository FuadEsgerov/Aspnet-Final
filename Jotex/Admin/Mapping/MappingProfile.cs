using Admin.Models.Pages;
using Admin.Models.Service;
using AutoMapper;
using Repository.Models;

namespace Admin.Mapping
{
    public class MappingProfile:Profile
   
    {
        public MappingProfile()
    {
            CreateMap<Faq,FaqViewModel>();
            CreateMap<FaqViewModel, Faq>();
            CreateMap<SliderItem, SliderViewModel>();
            CreateMap<SliderViewModel, SliderItem>();
            CreateMap<Testimonial, TestimonialViewModel>();
            CreateMap<TestimonialViewModel, Testimonial>();
            CreateMap<OurBlog, BlogViewModel>();
            CreateMap<BlogViewModel, OurBlog>();
            CreateMap<Service, ServicesViewModel>();
            CreateMap<ServicesViewModel, Service>();
            CreateMap<ServiceDetail, ServicesDetailViewModel>();
            CreateMap<ServicesDetailViewModel, ServiceDetail>();
            CreateMap<LikeableArea, LikeableViewModel>();
            CreateMap<LikeableViewModel, LikeableArea>();
            CreateMap<About, AboutUsViewModel>();
            CreateMap<AboutUsViewModel, About>();
            CreateMap<CaseStudy, CaseViewModel>();
            CreateMap<CaseViewModel, CaseStudy>();
            CreateMap<OurAgent, AgentViewModel>();
            CreateMap<AgentViewModel, OurAgent>();


        }
}
}
