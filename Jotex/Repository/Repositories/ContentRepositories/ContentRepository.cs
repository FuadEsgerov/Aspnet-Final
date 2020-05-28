﻿using Microsoft.EntityFrameworkCore;
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

    
    }
}
