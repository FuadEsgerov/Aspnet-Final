using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.BlogRepositories
{
   public interface IAboutRepository
    {
        IEnumerable<About> GetAbouts();
        IEnumerable<OurAgent> GetOurAgents();
        Setting GetSettings();
    }
}
