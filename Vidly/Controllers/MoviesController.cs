using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "LOL"},
                new Movie {Name = "Wall-E"}
            };
            return View(movies);
        }

        // GET
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "LOL"};
            var customer = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary Williams"},
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewModel);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Show(int id)
        {
            return Content(id.ToString());
        }
    }
}