using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
public class JotexDbContext:DbContext
    {
        public JotexDbContext(DbContextOptions<JotexDbContext>options):base(options) { }

        public DbSet<About> Abouts { get; set; }
   
        public DbSet<OurAgent> Agents { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OurBestPlan> OurBestPlans { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<Company> Company { get; set; }

        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<CoverdAds> CovardAds { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<LikeableArea> LikeableAreas { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceDetail> ServiceDetails { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SocialMediaAccount> SocialMediaAccounts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<OurBlog> OurBlogs { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<Label> Labels { get; set; }


    }
}
