using Aspdotnet_Test.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aspdotnet_Test.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person();
            person.Name = "janis";
            person.Surname = "zupa";
            person.IsMale = true;
            person.Age = 35;
            person.Address = "Ķarotes iela 3";
            person.Email = "janiszupa@inbox.lv";
            return View(person);
        }
    }
}
