using ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movie = new Movie() { Title = "Eqan" };
            var customers = new List<Customer>
            {
                new Customer { name = "Ahmad" },
                new Customer { name = "Eqan" }
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        } 

        public IActionResult Random(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue) { pageIndex = 1; }
            if(String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            //return Content("Hello World");
            //return NotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy="name"});
        }

        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "-" + month);
        }
    }
}
