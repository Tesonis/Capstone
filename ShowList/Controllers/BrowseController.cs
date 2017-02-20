using ShowList.Models;
using ShowList.Models.ShowViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowList.Controllers
{

    /// <summary>
    /// Browse Controller for the browse page
    /// </summary>
    public class BrowseController : Controller
    {
        //set Show repository
        private ShowRepository showRep;

        /// <summary>
        /// initialize constructor
        /// </summary>
        public BrowseController()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            showRep = new ShowRepository(context);
        }

        /// <summary>
        /// Initialize Browse page based on filter and search variables
        /// Default values are empty for strings, which will display all
        /// </summary>
        /// <param name="showGenre">string</param>
        /// <param name="showStatus">string</param>
        /// <param name="showLength">string</param>
        /// <param name="searchString">string</param>
        /// <returns>list of shows</returns>
        [HttpGet]
        public ActionResult Browse(string showGenre, string showStatus, string showLength, string searchString)
        {
            var shows = from x in showRep.GetAll()
                        select x;
            //Genre Filter code
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

            //Status Filter Code
            var StatusLst = new List<string>();
            var statusQuery = from d in showRep.GetAll()
                            orderby d.Status
                            select d.Status;
            StatusLst.AddRange(statusQuery.Distinct());
            ViewBag.showStatus = new SelectList(StatusLst);

            //Length Filter Code
            List<string> Length = new List<string>();
            Length.Add("Short (< 50 Episodes)");
            Length.Add("Medium ( 50 - 100 Episodes)");
            Length.Add("Long (100 - 200 Episodes)");
            Length.Add("Very Long (200+ Episodes)");
            ViewBag.showLength = new SelectList(Length);

            //Deploy filter to return updated list of shows based on parameters set
            if (!String.IsNullOrEmpty(searchString))
            {
                shows = shows.Where(s => s.Name.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(showGenre))
            {
                shows = shows.Where(x => x.PrimaryGenre == showGenre || x.SencondaryGenre == showGenre);
            }
            if (!string.IsNullOrEmpty(showStatus))
            {
                shows = shows.Where(x => x.Status == showStatus);
            }
            if (!string.IsNullOrEmpty(showLength))
            {
                if (showLength == "Short (< 50 Episodes)")
                {
                    shows = shows.Where(x => x.TotalEp < 50);
                }
                else if (showLength == "Medium ( 50 - 100 Episodes)")
                {
                    shows = shows.Where(x => x.TotalEp < 100);
                }
                else if (showLength == "Long (100 - 200 Episodes)")
                {
                    shows = shows.Where(x => x.TotalEp < 200);
                }
                else
                {
                    shows = shows.Where(x => x.TotalEp > 200);
                }
            }
            //returns updated list of shows
            return View(shows);
        }

        /// <summary>
        /// Post method for browse page for when the pages are reloaded due to a submit button on the view
        /// Basically the same code as the initialize metho ,but utilizes the posted variables from browseViewModel to set the search filters
        /// </summary>
        /// <param name="browseViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Browse(BrowseViewModel browseViewModel)
        {
            var shows = from x in showRep.GetAll()
                        select x;
            //Genre Filter code
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

            //Status Filter Code
            var StatusLst = new List<string>();
            var statusQuery = from d in showRep.GetAll()
                              orderby d.Status
                              select d.Status;
            StatusLst.AddRange(statusQuery.Distinct());
            ViewBag.showStatus = new SelectList(StatusLst);

            //Length Filter Code
            List<string> Length = new List<string>();
            Length.Add("Short (< 50 Episodes)");
            Length.Add("Medium ( 50 - 100 Episodes)");
            Length.Add("Long (100 - 200 Episodes)");
            Length.Add("Very Long (200+ Episodes)");
            ViewBag.showLength = new SelectList(Length);

            //Deploy filters to list of shows
            if (!String.IsNullOrEmpty(browseViewModel.SearchString))
            {
                shows = shows.Where(s => s.Name.Contains(browseViewModel.SearchString));
            }
            if (!string.IsNullOrEmpty(browseViewModel.ShowGenre))
            {
                shows = shows.Where(x => x.PrimaryGenre == browseViewModel.ShowGenre || x.SencondaryGenre == browseViewModel.ShowGenre);
            }
            if (!string.IsNullOrEmpty(browseViewModel.ShowStatus))
            {
                shows = shows.Where(x => x.Status == browseViewModel.ShowStatus);
            }
            if (!string.IsNullOrEmpty(browseViewModel.ShowLength))
            {
                if (browseViewModel.ShowLength == "Short (< 50 Episodes)")
                {
                    shows = shows.Where(x => x.TotalEp < 50);
                }
                else if (browseViewModel.ShowLength == "Medium ( 50 - 100 Episodes)")
                {
                    shows = shows.Where(x => x.TotalEp < 100);
                }
                else if (browseViewModel.ShowLength == "Long (100 - 200 Episodes)")
                {
                    shows = shows.Where(x => x.TotalEp < 200);
                }
                else
                {
                    shows = shows.Where(x => x.TotalEp > 200);
                }
            }
            //returns updated list of shows
            return View(shows);
        }
    }
}