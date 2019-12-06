using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Squidofus.Models;
using Squidofus.ViewModels;

namespace Squidofus.Controllers
{
    public class PersonnageController : Controller
    {
        private SquidofusContext _context;
        private readonly ILogger<PersonnageController> _logger;

        public PersonnageController(ILogger<PersonnageController> logger, SquidofusContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            // if (id == 0 || id > 12)
            // {
            //     return Error();
            // }

            Class classe = _context.Class.Where(x => x.IdClass == id).FirstOrDefault();

            if (classe == null)
            {
                return Error();
            }

            PersonnageViewModel cd = new PersonnageViewModel()
            {
                Class = classe,
                ClassDetail = _context.ClassDetail.Where(x => x.IdClass == id).ToList()
            };

            return View(cd);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}