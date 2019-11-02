using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Squidofus.Models;

namespace Squidofus.Controllers
{
    public class PersonnagesController : Controller
    {
        List<string> _personnages = new List<string>{
            "Cra",
            "Ecaflip",
            "Eniripsa",
            "Enutrof",
            "Feca",
            "Iop",
            "Osamodas",
            "Pandawa",
            "Sacrieur",
            "Sadida",
            "Sram",
            "Xelor"
        };
        private readonly ILogger<PersonnagesController> _logger;

        public PersonnagesController(ILogger<PersonnagesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Details(string classe)
        {
            if (!_personnages.Contains(classe))
            {
                return Error();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}