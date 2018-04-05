using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        //List of Movies
        public List<Movie> movies;

        //SelectList contains the list of genres
        public SelectList genres;

        //Contains the selected genre
        public string movieGenre { get; set; }
    }
}
