using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.AboutRepositories
{
   public interface IAboutRepository
    {
        IEnumerable<About> GetAbouts();
        IEnumerable<OurAgent> GetOurAgents();
        Setting GetSettings();
        IEnumerable<About> GetAllAbouts();
        About CreateAbout(About model);
        About GetAboutById(int id);
        void UpdateAbout(About aboutToUpdate, About model);
        void DeleteAbout(About about);
        void RemovePhotoById(int id);
        void AddPhoto(About aboutPhoto);
    }
}
