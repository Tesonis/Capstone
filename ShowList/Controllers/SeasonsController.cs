using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShowList.Models;

namespace ShowList.Controllers
{
    /// <summary>
    /// Seasons controller for Admin views (Season)
    /// </summary>
    public class SeasonsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        /// <summary>
        /// GET: Seasons
        /// </summary>
        /// <returns>list of all seasons in database</returns>
        public ActionResult Index()
        {
            var seasons = db.Seasons.Include(s => s.Show);
            return View(seasons.ToList());
        }

        /// <summary>
        /// GET: Seasons/Details/5
        /// </summary>
        /// <param name="id">Season ID</param>
        /// <returns>Season based on id</returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season season = db.Seasons.Find(id);
            if (season == null)
            {
                return HttpNotFound();
            }
            return View(season);
        }

        /// <summary>
        /// GET: Seasons/Create
        /// </summary>
        /// <returns>create season view</returns>
        public ActionResult Create()
        {
            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name");
            return View();
        }

        // POST: Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Create season object from posted values
        /// </summary>
        /// <param name="season">Season</param>
        /// <returns>season view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShowID,SeasonID,SeasonYear")] Season season)
        {
            if (ModelState.IsValid)
            {
                //if valid, add season and save
                db.Seasons.Add(season);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name", season.ShowID);
            return View(season);
        }

        // GET: Seasons/Edit/5
        /// <summary>
        /// Edit Season based on ID
        /// </summary>
        /// <param name="id">Season ID</param>
        /// <returns>Edit view</returns>
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season season = db.Seasons.Find(id);
            if (season == null)
            {
                return HttpNotFound();
            }
            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name", season.ShowID);
            return View(season);
        }

        // POST: Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        /// <summary>
        /// Post edit and update season object
        /// </summary>
        /// <param name="season">Season</param>
        /// <returns>season view</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShowID,SeasonID,SeasonYear")] Season season)
        {
            if (ModelState.IsValid)
            {
                //if valid, update object state and save
                db.Entry(season).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ShowID = new SelectList(db.Shows, "ShowID", "Name", season.ShowID);
            return View(season);
        }

        // GET: Seasons/Delete/5
        /// <summary>
        /// Delete View based on ID
        /// </summary>
        /// <param name="id">Season ID</param>
        /// <returns>delete view</returns>
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Season season = db.Seasons.Find(id);
            if (season == null)
            {
                return HttpNotFound();
            }
            return View(season);
        }

        // POST: Seasons/Delete/5
        /// <summary>
        /// Delete season from post
        /// </summary>
        /// <param name="id">Season ID</param>
        /// <returns>view</returns>
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //find season by id and remove from dbcontext
            Season season = db.Seasons.Find(id);
            db.Seasons.Remove(season);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
