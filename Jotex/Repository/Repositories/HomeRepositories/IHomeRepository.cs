using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.HomeRepositories
{
   public interface IHomeRepository
    {
        Setting GetSettings();
        IEnumerable<About> GetAbouts();
        IEnumerable<CoverdAds> GetCoverdAds();
        IEnumerable<LikeableArea> GetLikeableAreas();
        IEnumerable<OurBestPlan> GetOurBestPlans();
        IEnumerable<Label> GetLabels();
        IEnumerable<OurBlog> GetOurBlogs();
        IEnumerable<Count> GetCounts();
        IEnumerable<SliderItem> GetSliders();
        SliderItem CreateSlider(SliderItem model);
        SliderItem GetSliderById(int id);
        void UpdateSlider(SliderItem sliderToUpdate, SliderItem model);
        void DeleteSlider(SliderItem slider);
        IEnumerable<LikeableArea> GetAllAreas();
        LikeableArea CreateArea(LikeableArea model);
        LikeableArea GetAreaById(int id);
        void UpdateArea(LikeableArea areaToUpdate, LikeableArea model);
        void DeleteArea(LikeableArea area);
        void RemovePhotoById(int id);
        void AddPhoto(SliderItem slidePhoto);


    }
}
