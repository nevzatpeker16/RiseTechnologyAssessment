﻿using Buisness.Abstract;
using Entities.Concerate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
            Task.Run(() => _personService.AddPerson(person));
            return null;
        }
        [HttpPost("deleteperson")]
        public IActionResult DeletePerson(Person person)
        {
            return View();

        }
        [HttpPost("updateperson")]
        public IActionResult UpdatePerson(Person person)
        {
            return View();

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
