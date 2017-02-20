using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using ShowList.Models;
using ShowList.Models.ShowViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ShowList.Controllers
{

    /// <summary>
    /// Show Controller for Admin pages and Showpage
    /// </summary>
    public class ShowController : Controller
    {
        private ShowRepository showRep;
        private UserShowRepository userShowRep;
        protected UserManager<ApplicationUser> UserManager { get; set; }
        /// <summary>
        /// initialize dbcontext, usermanager and repositories
        /// </summary>
        public ShowController()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            showRep = new ShowRepository(context);
            userShowRep = new UserShowRepository(context);
        }

        /// <summary>
        /// Gets the showpage based on the show id and values tied to the user
        /// </summary>
        /// <param name="id">Show ID</param>
        /// <returns>showpage view</returns>
        public ActionResult ShowPage(int? id)
        {
            //check for null id
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show =  showRep.GetByID(id.Value);
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            List<string> Statuses = new List<string>();
            Statuses.Add("Watching");
            Statuses.Add("Completed");
            Statuses.Add("On-Hold");
            Statuses.Add("Plan to Watch");
            ViewBag.sl = new SelectList(Statuses);

            //Check if show exists in usershow based on the current user
            UserShow usershow = userShowRep.GetByID(User.Identity.GetUserId(), id.Value);
            
            //If show does not exist in usershow, then set it as a new usershow for the user
            if (usershow == null)
            {
                usershow = new UserShow { ShowID = id.Value, CurrentEp = 0, Show = show, ShowName = show.Name, Status = "Status", TotalEp = show.TotalEp, User = user, UserID = User.Identity.GetUserId() };
            }

            return View(usershow);
        }

        /// <summary>
        /// Post method for showpage
        /// Updates the useshow table based on values selected
        /// </summary>
        /// <param name="showpageviewmodel">showpageviewmodel</param>
        /// <returns>view</returns>
        [HttpPost]
        public ActionResult ShowPage(ShowPageViewModel showpageviewmodel)
        {
            ApplicationUser user = UserManager.FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            UserShow usershow = userShowRep.GetByID(User.Identity.GetUserId(), showpageviewmodel.ShowID);
            List<string> Statuses = new List<string>();
            Statuses.Add("Watching");
            Statuses.Add("Completed");
            Statuses.Add("On-Hold");
            Statuses.Add("Plan to Watch");
            ViewBag.sl = new SelectList(Statuses);
            //If current show did not exist in usershow table
            if (usershow == null)
            {
                    // add usershow to table
                    usershow = new UserShow
                    {
                        ShowID = showpageviewmodel.ShowID,
                        CurrentEp = showpageviewmodel.CurrentEp,
                        ShowName = showpageviewmodel.ShowName,
                        Status = showpageviewmodel.Status,
                        TotalEp = showpageviewmodel.TotalEp,
                        UserID = User.Identity.GetUserId()
                    };
                    // if its valid, the save the table
                    if (ModelState.IsValid)
                    {
                        userShowRep.InsertObj(usershow);
                        userShowRep.Save();
                    }
            }
            //if the usershow exists in the usershow table
            else
            {
                //Check for delete button press
                if (showpageviewmodel.CurrentEp == -1)
                {
                    userShowRep.DeleteObj(user.Id, showpageviewmodel.ShowID);
                    userShowRep.Save();
                    return Redirect(Request.UrlReferrer.ToString());
                }
                //check for update button press
                else
                {
                    usershow.CurrentEp = showpageviewmodel.CurrentEp;
                    usershow.Status = showpageviewmodel.Status;
                    if (ModelState.IsValid)
                    {
                        userShowRep.UpdateObj(usershow);
                        userShowRep.Save();
                    }
                }
                
            }
            
            //returns usershow and reload the page
            usershow.Show = showRep.GetByID(showpageviewmodel.ShowID);
            usershow.User = user;
            return View(usershow);
        }

        /// <summary>
        /// Admin page for all shows
        /// Contains basic search function similar to the browse page
        /// </summary>
        /// <param name="showGenre">string</param>
        /// <param name="searchString">string</param>
        /// <returns>view</returns>
        public ActionResult index(string showGenre, string searchString)
        {
            var shows = from x in showRep.GetAll()
                        select x;

            var GenreLst = new List<string>();
            var GenreMerge = new List<string>();

            var GenreQry = from d in showRep.GetAll()
                           orderby d.PrimaryGenre
                           select d.PrimaryGenre;
            var GenreQry2 = from d in showRep.GetAll()
                            orderby d.SencondaryGenre
                            select d.SencondaryGenre;
            
            GenreMerge.AddRange(GenreQry.Distinct());
            GenreMerge.AddRange(GenreQry2.Distinct());
            GenreMerge.Sort();
            GenreMerge.RemoveAll(str => String.IsNullOrEmpty(str));
            GenreLst.AddRange(GenreMerge.Distinct());
            ViewBag.showGenre = new SelectList(GenreLst);


            if (!String.IsNullOrEmpty(searchString))
            {
                shows = shows.Where(s => s.Name.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(showGenre))
            {
                shows = shows.Where(x => x.PrimaryGenre == showGenre || x.SencondaryGenre == showGenre);
            }

            return View(shows);
        }

        // GET: Shows/Details/5
        /// <summary>
        /// Details of a specific show (Not avaiable from the view links)
        /// </summary>
        /// <param name="id">show ID</param>
        /// <returns>view</returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = showRep.GetByID(id.Value);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // GET: Shows/Create
        /// <summary>
        /// Create new show
        /// </summary>
        /// <returns>view</returns>
        public ActionResult Create()
        {
            return View();
        }
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        // POST: Shows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Create new show in table based on POST values
        /// </summary>
        /// <param name="show">Show</param>
        /// <returns>view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowID,Name,PrimaryGenre,SencondaryGenre,RunYears,summary,status,Rating")] Show show)
        {
            if (ModelState.IsValid)
            {
                //add show to table and save
                showRep.InsertObj(show);
                showRep.Save();
                return RedirectToAction("Index");
            }
            return View(show);
        }
        
        // GET: Shows/Edit/5
        /// <summary>
        /// Edit Show based on ID
        /// </summary>
        /// <param name="id">Show ID</param>
        /// <returns>view</returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = showRep.GetByID(id.Value);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // POST: Shows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Update show object from POST values
        /// </summary>
        /// <param name="show">Show</param>
        /// <returns>view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowID,Name,PrimaryGenre,SencondaryGenre,RunYears,summary,status,Rating")] Show show)
        {
            if (ModelState.IsValid)
            {
                showRep.UpdateObj(show);
                showRep.Save();
                return RedirectToAction("Index");
            }
            return View(show);
        }

        // GET: Shows/Delete/5
        /// <summary>
        /// Delete show from table
        /// </summary>
        /// <param name="id">Show ID</param>
        /// <returns>view</returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Show show = showRep.GetByID(id.Value);
            if (show == null)
            {
                return HttpNotFound();
            }
            return View(show);
        }

        // POST: Shows/Delete/5
        /// <summary>
        /// POST confirms delete based on Show ID
        /// </summary>
        /// <param name="id">show ID</param>
        /// <returns>view</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            showRep.DeleteObj(id);
            showRep.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {

            showRep.Dispose(disposing);
            base.Dispose(disposing);
        }

    }
}