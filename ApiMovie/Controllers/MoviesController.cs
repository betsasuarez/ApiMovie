using ApiMovie.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMovie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly List<Movie> _movies = new List<Movie>
    {
        new Movie { Id = 1, Title = "El Exorcista" },
        new Movie { Id = 2, Title = "Barbie" },
        new Movie { Id = 3, Title = "El Conjuro" },
        new Movie { Id = 4, Title = "Marte Necesita Mamas" }
    };

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return _movies;
        }
    }
}
