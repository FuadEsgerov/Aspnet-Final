using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.CaseRepositories
{
   public interface ICaseRepository
    {
        Setting GetSettings();
        IEnumerable<CaseStudy> GetCaseStudies();
        IEnumerable<OurAgent> GetOurAgents();
        IEnumerable<Service> GetServices();
    }
}
