using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jotex.Models
{
    public class HomeViewModel
    {
        public IEnumerable<About> Abouts { get; set; }
        public Setting Settings { get; set; }
        public IEnumerable<CoverdAds> CoverdAds { get; set; }

        public IEnumerable<LikeableArea> LikeableAreas { get; set; }
        public IEnumerable<Service> Services { get; set; }

        public IEnumerable<OurBestPlan> OurBestPlans { get; set; }
        public IEnumerable<Label> Labels { get; set; }
        public IEnumerable<OurBlog> OurBlogs { get; set; }
        public IEnumerable<Count> Counts { get; set; }

    }
}
