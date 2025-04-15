using WebApplication1.Models;

namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;

public class ScheduleController
{
    // app/schedule => [controller] = Animals
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET api/schedule/{id}
        [HttpGet("{id:int}")]
        public IActionResult Index(int id)
        {
            var schedules = Database.Schedules.Where(s => s.AnimalId == id).ToList();
            return Ok(schedules);
        }

        // POST api/schedule { Date = "15.04.2025", AnimalId = 2, Description = "Wizyta kontrolna", Price = 123.45 }
        [HttpPost]
        public IActionResult Add(Schedule schedule)
        {
            Database.Schedules.Add(schedule);
            return Created();
        }
    }
}

