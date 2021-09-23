using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Vidly.Data;
using Vidly.Dtos;
using Vidly.Models;
using Vidly.Utilities;

namespace Vidly.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MoviesController(ApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _context = applicationDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<MovieDto> GetAll()
        {

            return Ok(_context.Movie.Include(m => m.Genre)
                             .Select(_mapper.Map<Movie, MovieDto>)
                             .OrderBy(x => x.Name)
                             .ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<MovieDto> Get(int id)
        {
            var result = _context.Movie.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Movie, MovieDto>(result));
        }

        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult<MovieDto> Create(MovieDto movieDto)
        {
            if (!ModelState.IsValid) { return BadRequest(); }


            var movie = _mapper.Map<MovieDto, Movie>(movieDto);

            _context.Movie.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return CreatedAtAction(nameof(Get), new { id = movieDto.Id }, movieDto);
        }

        [HttpPut]
        public ActionResult<MovieDto> Update(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid) { return BadRequest(); }

            var findMovieFromDb = _context.Movie.FirstOrDefault(x => x.Id == id);

            if (findMovieFromDb == null)
                return NotFound();

            var result = _mapper.Map(movieDto, findMovieFromDb);

            _context.SaveChanges();
            return Ok(movieDto);

        }
        [HttpDelete("{id}")]
        public ActionResult<MovieDto> Delete(int id)
        {
            var movieObj = _context.Movie.FirstOrDefault(x => x.Id == id);
            if (movieObj == null)
            {
                return Json(new { success = false, message = "Error why deleting." });
            }

            var movieDto = _mapper.Map<Movie, MovieDto>(movieObj);
            _context.Movie.Remove(movieObj);
            _context.SaveChanges();
            return Json(new { success = true, message = "Delete successful" });

        }
       

    }
}
