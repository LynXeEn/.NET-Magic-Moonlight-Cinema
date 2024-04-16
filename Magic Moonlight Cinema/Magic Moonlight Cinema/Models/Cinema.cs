using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Magic_Moonlight_Cinema.Models
{
    public class Cinema
    {
        public Cinema()
        {
            movies = new List<Movie>();
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Movie> movies { get; set; }
    }
}