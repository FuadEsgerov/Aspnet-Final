using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
   public class ContentRepository:IContentRepository
    {
        private readonly JotexDbContext _context;

        public ContentRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                           .ToList();
        }


        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }
        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.OrderByDescending(t => t.AddedDate).ToList();
        }

        public IEnumerable<Service> GetServices()
        {
            return _context.Services.Include(s => s.Details).Include(s => s.Specs).Where(s => s.Status).ToList();
        }
        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.OrderByDescending(b => b.AddedDate).ToList();
        }

        public IEnumerable<OurAgent> GetOurAgents()
        {
            return _context.Agents.Include(a=>a.Service).Where(a => a.Status).Take(7).ToList();
        }

        public IEnumerable<OurBlog> GetOurBlogs(int take, int skip)
        {
            return _context.OurBlogs.OrderByDescending(t => t.AddedDate).Skip(skip).Take(take).ToList();
        }

        public IEnumerable<OurBlog> FindOurBlogs(int blogId)
        {
            return _context.OurBlogs.Where(b => b.Id == blogId).ToList();
        }

        public IEnumerable<Review> GetReviews(int blogId)
        {
            return _context.Reviews.Where(r => r.OurBlogId == blogId).ToList();
        }

        public IEnumerable<Testimonial> GetAllTestimonials()
        {
            return _context.Testimonials.ToList();
        }

        public Testimonial CreateTestimonial(Testimonial model)
        {
            model.AddedDate = DateTime.Now;
            _context.Testimonials.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Testimonial GetTestimonialById(int id)
        {
            return _context.Testimonials.Find(id);
        }

        public void UpdateTestimonial(Testimonial testimonialToUpdate, Testimonial model)
        {
            testimonialToUpdate.Status = model.Status;
            testimonialToUpdate.Review = model.Review;
            testimonialToUpdate.UserName = model.UserName;
            testimonialToUpdate.UserProfession = model.UserProfession;
            testimonialToUpdate.ModifiedBy = model.ModifiedBy;
            testimonialToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Remove(testimonial);
            _context.SaveChanges();
        }

        public IEnumerable<OurBlog> GetAllBlogs()
        {
            return _context.OurBlogs.ToList();
        }

        public OurBlog CreateBlog(OurBlog model)
        {
            model.AddedDate = DateTime.Now;
            _context.OurBlogs.Add(model);
            _context.SaveChanges();
            return model;
        }

        public OurBlog GetBlogById(int id)
        {
            return _context.OurBlogs.Find(id);
        }

        public void UpdateBlog(OurBlog blogToUpdate, OurBlog model)
        {
            blogToUpdate.Status = model.Status;
            blogToUpdate.Title = model.Title;
            blogToUpdate.Text = model.Text;
            blogToUpdate.Tag = model.Tag;
            blogToUpdate.Image = model.Image;
            blogToUpdate.Video = model.Video;
            blogToUpdate.SubTitle = model.SubTitle;
            blogToUpdate.BlogSlogan = model.BlogSlogan;
            blogToUpdate.SubText = model.SubText;
            blogToUpdate.ActionText = model.ActionText;
            blogToUpdate.EndPoint = model.EndPoint;
            blogToUpdate.ModifiedBy = model.ModifiedBy;
            blogToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteBlog(OurBlog blog)
        {
            _context.OurBlogs.Remove(blog);
            _context.SaveChanges();
        }
        //Service Admin
        public IEnumerable<Service> GetAllServices()
        {
            return _context.Services.ToList();
        }

        public Service CreateService(Service model)
        {
            model.AddedDate = DateTime.Now;
            _context.Services.Add(model);
            _context.SaveChanges();
            return model;
        }

        public Service GetServiceById(int id)
        {
            return _context.Services.Find(id);
        }

        public void UpdateService(Service serviceToUpdate, Service model)
        {
            serviceToUpdate.Status = model.Status;
            serviceToUpdate.Name = model.Name;
            serviceToUpdate.Logo = model.Logo;
            serviceToUpdate.ModifiedBy = model.ModifiedBy;
            serviceToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteService(Service service)
        {
            _context.Services.Remove(service);
            _context.SaveChanges();
        }

        public IEnumerable<ServiceDetail> GetAllServiceDetail()
        {
            return _context.ServiceDetails.Include(s=>s.Service).ToList();
        }

        public ServiceDetail CreateServiceDetail(ServiceDetail model)
        {
            model.AddedDate = DateTime.Now;
            _context.ServiceDetails.Add(model);
            _context.SaveChanges();
            return model;
        }

        public ServiceDetail GetServiceDetailById(int id)
        {
            return _context.ServiceDetails.Include(s => s.Service).FirstOrDefault(s => s.Id == id);
        }

        public void UpdateServiceDetail(ServiceDetail serviceDetailToUpdate, ServiceDetail model )
        {
            serviceDetailToUpdate.Status = model.Status;
            serviceDetailToUpdate.ServiceId = model.Id;      
            serviceDetailToUpdate.Information = model.Information;
            serviceDetailToUpdate.Image = model.Image;
            serviceDetailToUpdate.SubDetail = model.SubDetail;
            serviceDetailToUpdate.Document = model.Document;
            serviceDetailToUpdate.Detail = model.Detail;
            serviceDetailToUpdate.ModifiedBy = model.ModifiedBy;
            serviceDetailToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteServiceDetail(ServiceDetail serviceDetail)
        {
            _context.ServiceDetails.Remove(serviceDetail);
            _context.SaveChanges();
        }
    }
}
