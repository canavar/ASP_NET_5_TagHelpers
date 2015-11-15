using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ASP_NET_5_TagHelpers.Models;
using Microsoft.AspNet.Mvc;

namespace ASP_NET_5_TagHelpers
{
    public class MoviesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string imdbId)
        {
            List<Movie> movies = GetMovies();
            if (string.IsNullOrEmpty(imdbId))
            {
                return View(GetMovies());
            }
            else
            {
                return View(GetMovies().Where(m => m.ImdbId == imdbId));
            }
        }

        public List<Movie> GetMovies()
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie() { ImdbId = "tt0470752", Name = "Ex Machina" });
            movieList.Add(new Movie() { ImdbId = "tt2562232", Name = "Birdman" });
            movieList.Add(new Movie() { ImdbId = "tt0137523", Name = "Fight Club" });
            return movieList;
        }
    }
}
