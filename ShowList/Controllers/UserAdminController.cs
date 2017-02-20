using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShowList.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ShowList.Controllers
{
    /// <summary>
    /// User Admin Controller for Admin views for all reigstered users
    /// </summary>
    public class UserAdminController : Controller
    {
        
        protected UserManager<ApplicationUser> UserManager { get; set; }

        /// <summary>
        /// Initalize dbcontext and usermanager
        /// </summary>
        public UserAdminController()
        {
           ApplicationDbContext db = new ApplicationDbContext();
           UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        /// <summary>
        /// Index page with list of all users
        /// </summary>
        /// <returns>view</returns>
        public ActionResult Index()
        {
            return View(UserManager.Users.ToList());
        }

        // GET: Seasons/Details/5
        /// <summary>
        /// Details based on user id (Not available from view)
        /// </summary>
        /// <param name="id">user ID</param>
        /// <returns>view</returns>
        public ActionResult Details(string id)
        {
            if (id == "")
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }


        // GET: Seasons/Edit/5
        /// <summary>
        /// Edit user based on user ID
        /// only non public fields, but can add additional user settings easily
        /// </summary>
        /// <param name="id">user iD</param>
        /// <returns>view</returns>
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = UserManager.FindById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Update User object from POST values
        /// </summary>
        /// <param name="user">ApplicationUser</param>
        /// <returns>view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, UserName, PasswordHash, Roles, LockoutEnabled")] ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                UserManager.UpdateAsync(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }


        // GET: Shows/Delete/5
        /// <summary>
        /// Delete User based on ID
        /// </summary>
        /// <param name="id">user ID</param>
        /// <returns>view</returns>
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser user = UserManager.FindById(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Shows/Delete/5
        /// <summary>
        /// Confirm delete of user based on user ID
        /// </summary>
        /// <param name="id">User ID</param>
        /// <returns>view</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            UserManager.DeleteAsync(UserManager.FindById(id));

            return RedirectToAction("Index");
        }


    }
}
