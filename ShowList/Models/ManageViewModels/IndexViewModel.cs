using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowList.Models.ManageViewModels
{
    /// <summary>
    /// Index View model is for user settings, View models are also used heavily as a variable storage for HTTPPOST events
    /// </summary>
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string DefaultTab { get; set; }
        public bool MissedEp { get; set; }
        public bool Messages { get; set; }
    }
}