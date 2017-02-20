using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShowList.Models
{
    /// <summary>
    /// UserShow Entity containing keys and properties
    /// Note that UserShow contains a user entity and a show entity, thus making UserShow the
    /// highest entity object on the model hierarchy
    /// </summary>
    public class UserShow
    {
        [Key]
        [Required]
        [Column(Order = 0)]
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }
        [Key]
        [Required]
        [Column(Order = 1)]
        public int ShowID { get; set; }
        [ForeignKey("ShowID")]
        public Show Show { get; set; }
        [Required]
        [Column(Order = 2)]
        public string ShowName { get; set; }
        [Required]
        [Column(Order = 3)]
        public string Status { get; set; }
        [Required]
        [Column(Order = 4)]
        public int CurrentEp { get; set; }
        [Column(Order = 5)]
        [Required]
        public int TotalEp { get; set; }
    }
}