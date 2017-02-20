using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowList.Models.ShowViewModels
{
    /// <summary>
    /// Browse view model for the browse page, also heavily used as a POST tool
    /// </summary>
    public class BrowseViewModel
    {
        public string SearchString { get; set; }
        public string ShowGenre { get; set; }
        public string ShowStatus { get; set; }
        public string ShowLength { get; set; }


    }
}