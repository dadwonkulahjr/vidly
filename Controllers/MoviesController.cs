using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Vidly.Utilities;

namespace Vidly.Controllers
{
    
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public MoviesController(ApplicationDbContext applicationDbContext, SignInManager<ApplicationUser> signInManager)
        {
            _dbContext = applicationDbContext;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Random()
        {
            if(User.IsInRole(RoleName.CanManageMovies) && _signInManager.IsSignedIn(User))
            return View("list");

            return View("readonlylist");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var result = _dbContext.Movie
                            .Include(x => x.Genre)
                            .FirstOrDefault(m => m.Id == id);
            if (result != null)
            {
                return View(result);
            }

            return NotFound();
        }

        [HttpGet]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IActionResult New()
        {
            var genre = _dbContext.Genre.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            var model = new CreateMovieViewModel
            {
                DropdownListForGenre = genre
            };

            return View("create", model);
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IActionResult New(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var createMovieVM = new CreateMovieViewModel(movie)
                {
                    DropdownListForGenre = _dbContext.Genre.Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                };

                return View("create", createMovieVM);
            }

            if (movie.Id == 0)
            {
                movie.Genre.DateAdded = System.DateTime.Now;
                _dbContext.Movie.Add(movie);
            }
            else
            {

            }

            return View("create");
        }


    }
}
