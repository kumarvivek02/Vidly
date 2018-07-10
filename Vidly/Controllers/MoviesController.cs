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
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = new Movie() { Name = "We will watch Shrek!!" };

            var customers = new List<Customer>
            {
                new Customer{Name ="Customer 1"},
                new Customer{Name ="Customer 2"}

            };

            var viewModel = new RandomMovieViewModel
            {

                Movie = movies,
                Customers = customers
            };

            return View(viewModel);

        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {

            if (!pageIndex.HasValue)
            { pageIndex = 1; }

            if (string.IsNullOrEmpty(sortBy))
            {

                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
        }

    }
}