using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.HomeRepositories
{
   public class HomeRepository:IHomeRepository
    {
        private readonly JotexDbContext _context;

        public HomeRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<About> GetAbouts()
        {
            return _context.Abouts.Where(c => c.Status).ToList();
        }

        public IEnumerable<CoverdAds> GetCoverdAds()
        {
            return _context.CovardAds.Where(c => c.Status).ToList();
        }

        public IEnumerable<Label> GetLabels()
        {
            return _context.Labels.Where(c => c.Status).ToList();
        }

        public IEnumerable<LikeableArea> GetLikeableAreas()
        {
            return _context.LikeableAreas.Where(c => c.Status).ToList();
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }

        public IEnumerable<OurBestPlan> GetOurBestPlans()
        {
            return _context.OurBestPlans.Where(c => c.Status).ToList();
        }

        public IEnumerable<OurBlog> GetOurBlogs()
        {
            return _context.OurBlogs.OrderByDescending(t => t.AddedDate).Take(3).ToList();
        }

        public IEnumerable<Count> GetCounts()
        {
            return _context.Counts.Where(c => c.Status).ToList();
        }

        public IEnumerable<SliderItem> GetSliders()
        {
            return _context.SliderItems.ToList();
        }

        public SliderItem CreateSlider(SliderItem model)
        {
            model.AddedDate = DateTime.Now;
            _context.SliderItems.Add(model);
            _context.SaveChanges();
            return model;
        }

        public SliderItem GetSliderById(int id)
        {
            return _context.SliderItems.Find(id);
        }

        public void UpdateSlider(SliderItem sliderToUpdate, SliderItem model)
        {
            sliderToUpdate.Status = model.Status;
            sliderToUpdate.Title = model.Title;
            sliderToUpdate.ActionText = model.ActionText;
            sliderToUpdate.Image = model.Image;
            sliderToUpdate.EndPoint = model.EndPoint;
            sliderToUpdate.Slogan = model.Slogan;
            sliderToUpdate.ModifiedBy = model.ModifiedBy;
            sliderToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteSlider(SliderItem slider)
        {
            _context.SliderItems.Remove(slider);
            _context.SaveChanges();
        }

        public IEnumerable<LikeableArea> GetAllAreas()
        {
            return _context.LikeableAreas.ToList();
        }

        public LikeableArea CreateArea(LikeableArea model)
        {
            model.AddedDate = DateTime.Now;
            _context.LikeableAreas.Add(model);
            _context.SaveChanges();
            return model;
        }

        public LikeableArea GetAreaById(int id)
        {
            return _context.LikeableAreas.Find(id);
        }

        public void UpdateArea(LikeableArea areaToUpdate, LikeableArea model)
        {
            areaToUpdate.Status = model.Status;
            areaToUpdate.Title = model.Title;
            areaToUpdate.Information = model.Information;
            areaToUpdate.CallUs = model.CallUs;
            areaToUpdate.Phone = model.Phone;
            areaToUpdate.Phote = model.Phote;
            areaToUpdate.Experience = model.Experience;
            areaToUpdate.Year = model.Year;
            areaToUpdate.Video = model.Video;
            areaToUpdate.ActionText = model.ActionText;
            areaToUpdate.EndPoint = model.EndPoint;
            areaToUpdate.ModifiedBy = model.ModifiedBy;
            areaToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteArea(LikeableArea area)
        {
            _context.LikeableAreas.Remove(area);
            _context.SaveChanges();
        }

        public void RemovePhotoById(int id)
        {
            SliderItem slidePhoto = _context.SliderItems.Find(id);

            _context.SliderItems.Remove(slidePhoto);

            _context.SaveChanges();
        }

        public void AddPhoto(SliderItem slidePhoto)
        {
            _context.SliderItems.Add(slidePhoto);
            _context.SaveChanges();
        }
    }
}
