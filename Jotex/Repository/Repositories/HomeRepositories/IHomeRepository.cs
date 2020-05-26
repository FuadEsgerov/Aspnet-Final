using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.BlogRepositories
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

    }
}
