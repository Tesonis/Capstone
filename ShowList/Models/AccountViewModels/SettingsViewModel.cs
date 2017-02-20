using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShowList.Models.AccountViewModels
{
    /// <summary>
    /// View model for settings
    /// This view model is used on the profile page as a way to pass in all of the user object properties
    /// </summary>
    public class SettingsViewModel
    {
        public SettingsViewModel() { }

        public SettingsViewModel(ApplicationUser user)
        {
            Email = user.Email;
            Gender = user.Gender;
            AboutMe = user.AboutMe;
            Location = user.Location;
            DefaultTab = user.DefaultTab;
            MissedEp = user.MissedEp;
            Messages = user.Messages;
            ShowList = user.ShowList;

        }

        [Required, EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Display(Name = "AboutMe")]
        public string AboutMe { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "DefaultTab")]
        public string DefaultTab { get; set; }
        [Display(Name = "EpisodeNotification")]
        public bool MissedEp { get; set; }
        [Display(Name = "Messages")]
        public bool Messages { get; set; }
        [Display(Name = "ShowList")]
        public ICollection<UserShow> ShowList { get; set; }
    }
}