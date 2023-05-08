using Microsoft.AspNetCore.Mvc;
using restUdemy.Models;
using restUdemy.Services;

namespace restUdemy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;


        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.GetAll());
        }

        [HttpGet("{ id }")]
        public IActionResult Get(long id)
        {
            var person = _personService.Get(id);
            if(person == null) { return  NotFound(); }
            return Ok(person); 
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            
            if (person == null) { return BadRequest(); }
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person person)
        {

            if (person == null) { return BadRequest(); }
            return Ok(_personService.Update(person));
        }

        [HttpDelete("{ id }")]
        public IActionResult Delete(long id)
        {
            _personService.Delete(id);
            return NoContent();
        }

    }
}