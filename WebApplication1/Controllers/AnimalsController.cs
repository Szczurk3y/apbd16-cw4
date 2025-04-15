using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

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
            var animals = Database.Animals;
            return Ok(animals);
        }
        
        // GET api/animals/{id} => {id} = 1
        [HttpGet("{id:int}")]
        public IActionResult Index(int id)
        {
            var animal = Database.Animals.Find(x => x.Id == id);
            return Ok(animal);
        }

        // POST api/animals { Id = 5, Name = "Test kot 3", Category = "CAT", Weight = 4.1, Color = "Black" },
        [HttpPost]
        public IActionResult Create([FromBody] Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }
        
        // PUT api/animals/ { Id = 5, Name = "Test kot 3", Category = "CAT", Weight = 4.1, Color = "Black" },
        [HttpPut]
        public IActionResult Update(Animal animal)
        {
            var index = Database.Animals.FindIndex(a => a.Id == animal.Id);
            Database.Animals[index] = animal;
            return Ok();
        }

        // DELETE api/animals/{id} => {id} = 1
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var index = Database.Animals.FindIndex(a => a.Id == id);
            Database.Animals.RemoveAt(index);
            return Ok();
        }

        [HttpGet("getbyname/{name}")]
        public IActionResult GetByName(string name)
        {
            var animals = Database.Animals.Where(a => a.Name.ToLower().Contains(name.ToLower())).ToList();
            return Ok(animals);
        }
        
    }
}

