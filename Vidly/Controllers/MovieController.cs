using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Save()
        {
            return View();
        }

        // GET: Movie/random
        public ActionResult Random()
        {

            
            var movie = new Movie() { Name = "MI3" };

            var customers = new List<Customers>
            {
                new Customers { Name="Customer1" },
                new Customers { Name="Customer2"}

            };

            RandomMovieViewModel random = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };


            //return View(movie);
            //return Content("Hi this is contents");
            //return HttpNotFound(); 
            //return RedirectToAction("Index","Home",new { page=1,sortby="name"});
            return View(random);


        }
        public ActionResult edit(int id)
        {
            return Content("id=" + id);

        }

        //Movies
        public ActionResult Index( int? PageIndex,string sortby)
        {
            if (!PageIndex.HasValue )
            {
                PageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(string.Format("PageIndex={0} & sortBy={1}", PageIndex, sortby));
        }
        [Route("movie/released/{year}/{month:regex(\\d{2}):range(1,12)}") ]
        public ActionResult ByreleasedDate(int year,int month)
        {

            return Content(year+"/"+ month ) ;
        }
    }
}