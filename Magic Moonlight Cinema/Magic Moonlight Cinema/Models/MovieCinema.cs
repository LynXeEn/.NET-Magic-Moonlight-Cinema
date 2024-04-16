using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magic_Moonlight_Cinema.Models
{
    public class MovieCinema
    {
        public MovieCinema()
        {
            movies = new List<Movie>();
        }

        public int MovieId { get; set; }
        public int CinemaId { get; set; }
        public Cinema cinema { get; set; }
        public List<Movie> movies { get; set; }
    }
}