using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AboutRepositories
{
    public class AboutRepository : IAboutRepository
    {
        private readonly JotexDbContext _context;

        public AboutRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OurAgent> GetOurAgents()
        {
            return _context.Agents.Where(a => a.Status).Take(7).ToList();
        }

        public IEnumerable<About> GetAbouts()
        {
            return _context.Abouts.Where(a => a.Status).ToList(); 
        }

        public Setting GetSettings()
        {
            return _context.Settings.Where(s => s.Status).FirstOrDefault();
        }

        public IEnumerable<About> GetAllAbouts()
        {
            return _context.Abouts.ToList();
        }

        public About CreateAbout(About model)
        {
            model.AddedDate = DateTime.Now;
            _context.Abouts.Add(model);
            _context.SaveChanges();
            return model;
        }

        public About GetAboutById(int id)
        {
            return _context.Abouts.Find(id);
        }

        public void UpdateAbout(About aboutToUpdate, About model)
        {
            aboutToUpdate.Status = model.Status;
            aboutToUpdate.Title = model.Title;
            aboutToUpdate.Text = model.Text;
            aboutToUpdate.Information = model.Information;
            aboutToUpdate.Phone = model.Phone;
            aboutToUpdate.SubDetail = model.SubDetail;
            aboutToUpdate.Image = model.Image;
            aboutToUpdate.ActionText = model.ActionText;
            aboutToUpdate.EndPoint = model.EndPoint;
            aboutToUpdate.ModifiedBy = model.ModifiedBy;
            aboutToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }

        public void DeleteAbout(About about)
        {
            _context.Abouts.Remove(about);
            _context.SaveChanges();
        }
    }
}
