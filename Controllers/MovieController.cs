using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;
using Videly.ViewModel;


namespace Videly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        
        
            public ViewResult Index()
        {
            var movies = GetMovies(); 
            return View(movies);
        }

        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Movies {mid = 1, mName = "Shrek" },
                new Movies {mid = 2, mName = "wall" }
            };

        }

           /* var movies = new List<Movies>
            {
                new Movies {mName = "movie1" },
                new Movies {mName = "movie2" }

            };

            var customer = new List<Customer>
            {
                new Customer {Name = "customer 1" },
                new Customer {Name = "customer 2" }
            };

            var viewModel = new RandomViewModel
            {
                Movies = movies,
            Customer = customer
            };
            return View(viewModel);*/


        }
    }
}