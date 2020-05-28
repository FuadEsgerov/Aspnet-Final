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
     


    }
}
