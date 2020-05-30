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
        IEnumerable<CaseStudy> GetAllCases();
        CaseStudy CreateCase(CaseStudy model);
        CaseStudy GetCaseById(int id);
        void UpdateCase(CaseStudy caseStudyToUpdate, CaseStudy model);
        void DeleteCase(CaseStudy caseStudy);
        IEnumerable<OurAgent> GetAllAgents();
        OurAgent CreateAgent(OurAgent model);
        OurAgent GetAgentById(int id);
        void UpdateAgent(OurAgent agentToUpdate, OurAgent model);
        void DeleteAgent(OurAgent agent );
    }
}
