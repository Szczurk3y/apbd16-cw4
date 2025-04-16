using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // app/schedules => [controller] = Animals
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        // GET api/schedules/animal/{Id}
        [HttpGet("animal/{Id:int}")]
        public IActionResult Index(int id)
        {
            var schedules = Database.Schedules.Where(s => s.AnimalId == id).ToList();
            return Ok(schedules);
        }

        // POST api/schedules/ { Date = "15.04.2025", AnimalId = 2, Description = "Wizyta kontrolna", Price = 123.45 }
        [HttpPost]
        public IActionResult Add(Schedule schedule)
        {
            Database.Schedules.Add(schedule);
            return Ok("Schedule created.");
        }
    }
}