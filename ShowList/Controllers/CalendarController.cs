
using Microsoft.AspNet.Identity;
using ShowList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowList.Controllers
{
    /// <summary>
    /// Calendar controller for the Calendar view (calendarList)
    /// </summary>
    public class CalendarController : Controller
    {
        private UserShowRepository userShowRep;
        /// <summary>
        /// Initialize dbcontext and usershow repository
        /// </summary>
        public CalendarController()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            userShowRep = new UserShowRepository(context);
        }

        /// <summary>
        /// CalendarList uses a query to select shows from the current user that has a nextepisode value set
        /// </summary>
        /// <returns>List of shows containing non null nextepisode</returns>
        public ActionResult CalendarList()
        {

            IEnumerable<UserShow> airingShowsQuery = from d in userShowRep.GetAll()
                              where d.Show.NextEpisode != null where d.UserID == User.Identity.GetUserId()
                                                     select d;
            return View(airingShowsQuery);
        }

    }
}