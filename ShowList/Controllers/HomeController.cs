using ShowList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowList.Controllers
{
    
    /// <summary>
    /// Default Home controller for homepage and contact page
    /// </summary>
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        /// <summary>
        /// Homepage
        /// </summary>
        /// <returns>index view</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Contact Page
        /// </summary>
        /// <returns>contact view</returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}