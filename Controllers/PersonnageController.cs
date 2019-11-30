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
    public class PersonnageController : Controller
    {
        List<string> _personnages = new List<string>{
            "cra",
            "ecaflip",
            "eniripsa",
            "enutrof",
            "feca",
            "iop",
            "osamodas",
            "pandawa",
            "sacrieur",
            "sadida",
            "sram",
            "xelor"
        };
        private readonly ILogger<PersonnageController> _logger;

        public PersonnageController(ILogger<PersonnageController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Details(string classe)
        {
            if (String.IsNullOrEmpty(classe) ||
                !_personnages.Contains(classe))
            {
                return Error();
            }
            ViewBag.Classe = classe;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}