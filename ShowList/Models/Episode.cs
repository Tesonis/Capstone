using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShowList.Models
{
    public class Episode
    {
        [Key]
        [ForeignKey("Season")]
        [Required]
        public int ShowID { get; set; }
        [Key]
        [ForeignKey("Season")]
        [Required]
        public int SeasonID { get; set; }
        [ForeignKey("ShowID,SeasonID")]
        public Season Season { get; set; }
        [Key]
        [Required]
        public int EpisodeID { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime AirDate { get; set; }
    }
}