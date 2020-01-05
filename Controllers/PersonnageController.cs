using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Squidofus.Models;
using Squidofus.ViewModels;
// using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

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
            if (!_context.Class.Where(x => x.IdClass == id).Any())
            {
                return Error();
            }

            PersonnageViewModel cd = new PersonnageViewModel()
            {
                Class = _context.Class.Where(x => x.IdClass == id).Include(x => x.ClassBuild).ThenInclude(x => x.ClassBuildDetail).FirstOrDefault(),
                ClassDetail = _context.ClassDetail.Where(x => x.IdClass == id).ToList(),
                Spells = _context.Spell.Include(x => x.SpellDetail).ThenInclude(x => x.SpellEffect).Where(spell => spell.IdClass == id).ToList(),
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