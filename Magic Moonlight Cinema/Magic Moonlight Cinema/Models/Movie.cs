using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Magic_Moonlight_Cinema.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public virtual Cinema CinemaBroadcast { get; set; }
    }
}