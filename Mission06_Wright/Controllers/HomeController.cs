using Microsoft.AspNetCore.Mvc;
using Mission06_Wright.Models;
using System.Diagnostics;

namespace Mission06_Wright.Controllers
{
    public class HomeController : Controller
    {
        private JoelMoviesContext _context; // private variable which has scope in the whole class
        public HomeController(JoelMoviesContext temp) // Constructor
        { 
            _context = temp; // temp has scope only within this public constructor
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetToKnowJoel()
        {
            return View();
        }
        public IActionResult MovieSubmit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSubmit(MovieRec response)
        {
            _context.MovieRecommendations.Add(response); // Add record to database
            _context.SaveChanges();

            return RedirectToAction("MovieSubmit");
        }
    }
}
