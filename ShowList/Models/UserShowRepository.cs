using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShowList.Models
{
    /// <summary>
    /// UserShow utilizes the interface to do simple CRUD functionality with method calls
    /// </summary>
    public class UserShowRepository : IJoinTableRepository<UserShow, string, int>
    {
        private ApplicationDbContext context;

        public UserShowRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void DeleteObj(string userid, int showid)
        {
            context.UserShows.Remove(GetByID(userid, showid));
        }

        public IEnumerable<UserShow> GetAll()
        {

            return context.UserShows.Include(us => us.User).Include(us => us.Show);
        }

        public UserShow GetByID(string userid, int showid)
        {
            return GetAll().SingleOrDefault(us => us.UserID == userid && us.ShowID == showid);
        }

        public void InsertObj(UserShow obj)
        {
            context.UserShows.Add(obj);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateObj(UserShow obj)
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