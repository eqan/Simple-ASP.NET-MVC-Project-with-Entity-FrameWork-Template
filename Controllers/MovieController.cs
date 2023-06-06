using ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movies
        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        // GET: Movies/Details/5
        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }


        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewBag.Genres = _context.Genres.ToList();
            return View();
        }


        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Genres = _context.Genres.ToList();
            return View(movie);
        }


        // GET: Movies/Edit/5
        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            ViewBag.Genres = _context.Genres.ToList();
            return View(movie);
        }


        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie movie)
        {
            if (id != movie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Genres = _context.Genres.ToList();
            return View(movie);
        }


        // GET: Movies/Delete/5
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
