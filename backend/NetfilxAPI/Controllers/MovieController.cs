using Microsoft.AspNetCore.Mvc;

namespace NetfilxAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        public MovieController()
        {
            
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok("TopGun");
        }
    }
}
