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
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            _context.Movies.Add(response); //Adds record to the database
            _context.SaveChanges();

            return View("Confirmation", response); //Goes to confirmation screen along with the record on the database
        }

        public IActionResult MovieList(MovieApplicationContext _context)
        {
            var listOfMovies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(listOfMovies);
        }
    }
}
