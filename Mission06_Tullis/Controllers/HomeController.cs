using Microsoft.AspNetCore.Mvc;
using Mission06_Tullis.Models;
using System.Diagnostics;

namespace Mission06_Tullis.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.CategoryViewBag = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new Application());
        }

        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Adds record to the database
                _context.SaveChanges();

                return View("Confirmation", response); //Goes to confirmation screen along with the record on the database
            }
            else //Invalid data
            {
                ViewBag.CategoryViewBag = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

                return View(response);
            }  
        }

        public IActionResult MovieList()
        {
            var listOfMovies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(listOfMovies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.CategoryViewBag = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("AddMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Application updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(movieToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Application movieToDelete)
        {
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
