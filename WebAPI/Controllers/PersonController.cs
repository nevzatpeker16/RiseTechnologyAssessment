using Buisness.Abstract;
using Entities.Concerate;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class PersonController : Controller
    {

        IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("addperson")]
        public IActionResult AddPerson(Person person)
        {
            if (person == null)
            {
                return BadRequest();
            }
            else
            {
                _personService.AddPerson(person);
                return Ok("Person  Added");
            }
        }
        [HttpPost("deleteperson")]


        public IActionResult Index()
        {
            return View();
        }
    }
}
