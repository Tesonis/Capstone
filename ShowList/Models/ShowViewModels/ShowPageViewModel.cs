using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowList.Models.ShowViewModels
{
    /// <summary>
    /// Showpage view model for the showpage, used as a POST tool as well
    /// </summary>
    public class ShowPageViewModel
    {
        public int ShowID { get; set; }
        public int CurrentEp { get; set; }
        public string ShowName { get; set; }
        public string Status { get; set; }
        public int TotalEp { get; set; }
    }
}