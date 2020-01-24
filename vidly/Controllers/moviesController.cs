using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.viewModel;

namespace vidly.Controllers
{
    public class moviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = new List<Movie> {
                new Movie {Name="film1" },
                 new Movie {Name="film2" },
            };
            var ViewModel = new viewListMovies
            {
                listMovies= movies,
            };
            return View(ViewModel);
        }

        // GET: movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "shark" };
            var customers = new List<Customers>
            {
                new Customers {name ="c1" },
                  new Customers {name ="c2" },

            };
            var viewModel = new randomCustmorViewModel {
                movie = movie,
                customers = customers
            };
                return View(viewModel);
            //return Content("Hello World !");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "Home", new { page = 1, sortby = "name" });
        }
        public ActionResult Edit (int id)
        {
            return Content("id=" +id);
        }
      /*  public ActionResult Index(int? pageIndex ,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
        */
      /*  [Route("movies/release/{year}/{month:regex(\\d{2}):range(1,12)}")]
       public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year +"/"+month );
        }*/
    }
}