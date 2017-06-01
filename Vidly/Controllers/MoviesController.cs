using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Minion", Id = 1},
                new Movie {Name = "SHrek", Id = 2}
            };

            return View(new MovieList {Movies = movies});

        }

// GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Minions"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Alicia"},
                new Customer {Name = "Lily"},
                new Customer {Name = "Peter"}
            };

            var randomMovieView = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(randomMovieView);
        }

//        public ActionResult Edit(int movieId)
//        {
//            return Content("movieId: " + movieId);
//        }
//
//        public ActionResult Index(int? pageIndex, string sortBy)
//        {
//            if (!pageIndex.HasValue)
//            {
//                pageIndex = 1;
//            }
//
//            if (String.IsNullOrWhiteSpace(sortBy))
//            {
//                sortBy = "Name";
//            }
//
//            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
//
//        }


        [Route("movies/released/{year:min(2000):max(2017)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("{0} : {1}", year, month));
        }
    }
}