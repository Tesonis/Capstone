using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ShowList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowList.Controllers
{

    /// <summary>
    /// Profile Controller for the profile page
    /// </summary>
    public class ProfileController : Controller
    {
              
        private UserShowRepository userShowRep;
        /// <summary>
        /// Initialize dbcontext and Repository
        /// </summary>
        public ProfileController()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            userShowRep = new UserShowRepository(context);
        }
        /// <summary>
        /// Use viewbags values to display user settings so that it doesn't affect the usershows
        /// </summary>
        /// <returns>profile view</returns>
        public ActionResult myProfile()
        {
            //get current user
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>()
                .Users.Include(u => u.ShowList).Single(u => u.Email == System.Web.HttpContext.Current.User.Identity.Name);
            //set viewbag values to user settings
            ViewBag.UserShows = user.ShowList;
            ViewBag.Username = user.Email;
            ViewBag.Gender = user.Gender;
            ViewBag.Location = user.Location;
            ViewBag.DefaultTab = user.DefaultTab;
            ViewBag.AboutMe = user.AboutMe;
            //set viewbag value based on defaulttab setting
            ViewBag.allShows = user.ShowList.Count;
            ViewBag.Watching = user.ShowList.Count(s => s.Status == "Watching");
            ViewBag.Completed = user.ShowList.Count(s => s.Status == "Completed");
            ViewBag.OnHold = user.ShowList.Count(s => s.Status == "On-Hold");
            ViewBag.Plan = user.ShowList.Count(s => s.Status == "Plan to Watch");

            //returns just the view with no parameters, the usershow list will be initialized inside the view
            return View();  
        }

    }
}