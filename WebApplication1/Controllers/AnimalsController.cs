using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // app/animals => [controller] = Animals
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET api/animals
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hello world!");
        }
    }
}

