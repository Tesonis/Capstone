using ShowList.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShowList.Models
{
    /// <summary>
    /// Show Repository uses the repository interface to do simple CRUD functions with a method call
    /// </summary>
    public class ShowRepository : IRepository<Show, int>
    {
        private ApplicationDbContext context;

        public ShowRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void DeleteObj(int id)
        {
            context.Shows.Remove(GetByID(id));
        }

        public IEnumerable<Show> GetAll()
        {
            return context.Shows.Include(s => s.Seasons.Select(se => se.Episodes));
        }

        public Show GetByID(int id)
        {
            return GetAll().SingleOrDefault(s => s.ShowID == id);
        }

        public void InsertObj(Show obj)
        {
            context.Shows.Add(obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateObj(Show obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
    }
}