using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShowList.Models
{
    /// <summary>
    /// Season model containing the keys and the properties
    /// </summary>
    public class Season
    {
        [Key]
        public int ShowID { get; set; }
        [ForeignKey("ShowID")]
        public Show Show { get; set; }
        [Key]
        public int SeasonID { get; set; }
        public int SeasonYear { get; set; }
        public ICollection<Episode> Episodes { get; set; }
    }
}