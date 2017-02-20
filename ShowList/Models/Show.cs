using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShowList.Models
{
    /// <summary>
    /// Show Entity contains the keys and properties
    /// </summary>
    public class Show
    {
        [Key]
        public int ShowID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Network { get; set; }
        [Required]
        public string PrimaryGenre { get; set; }
        public string SencondaryGenre { get; set; }
        [Required]
        public string RunYears { get; set; }
        public ICollection<Season> Seasons { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public int TotalEp { get; set; }
        public DateTime? NextEpisode { get; set; }

    }
}