using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IContentRepository
    {
        IEnumerable<SliderItem> GetSliderItems();
        Setting GetSettings();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Testimonial> GetTestimonials();
        IEnumerable<Service> GetServices();
        IEnumerable<OurAgent> GetOurAgents();
        IEnumerable<OurBlog> GetOurBlogs(int take,int skip);
        IEnumerable<OurBlog> FindOurBlogs(int blogId);
        IEnumerable<Review> GetReviews(int blogId);
        IEnumerable<Testimonial> GetAllTestimonials();
        Testimonial CreateTestimonial(Testimonial model);
        Testimonial GetTestimonialById(int id);
        void UpdateTestimonial(Testimonial testimonialToUpdate, Testimonial model);
        void DeleteTestimonial(Testimonial testimonial);
        IEnumerable<OurBlog> GetAllBlogs();
        OurBlog CreateBlog(OurBlog model);
        OurBlog GetBlogById(int id);
        void UpdateBlog(OurBlog blogToUpdate, OurBlog model);
        void DeleteBlog(OurBlog blog);
        void RemovePhotoById(int id);
        void AddPhoto(OurBlog blogPhoto);
        IEnumerable<Service> GetAllServices();
        Service CreateService(Service model);
        Service GetServiceById(int id);
        void UpdateService(Service serviceToUpdate, Service model);
        void DeleteService(Service service);
        IEnumerable<ServiceDetail> GetAllServiceDetail();
        ServiceDetail CreateServiceDetail(ServiceDetail model);
        ServiceDetail GetServiceDetailById(int id);
        void UpdateServiceDetail(ServiceDetail serviceDetailToUpdate, ServiceDetail model);
        void DeleteServiceDetail(ServiceDetail serviceDetail);



    }
}
