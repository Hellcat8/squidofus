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

            if (cd.Class.IdClass == 2) // Ecaflip
            {
                ViewBag.RouletteEffectsStd = GetRouletteEffectsStd();
                ViewBag.RouletteEffectsCrit = GetRouletteEffectsCrit();
            } 

            return View(cd);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string[] GetRouletteEffectsStd()
        {
            return new string[]{
                    "+2 à 3 PM",
                    "+2 à 3 PA",
                    "+50 de dommages",
                    "+50 de soins",
                    "+400 en agilité",
                    "+400 en chance",
                    "+400 en force",
                    "+400 en intelligence",
                    "+50 aux coups critiques",
                    "Enlève les envoûtements",
                    "+5 à la portée",
                    "Fait passer le tour suivant",
                    "PDV rendus : 5000"
                };
        }

        private string[] GetRouletteEffectsCrit()
        {
            return new string[]{
                    "+3 PM",
                    "+3 PA",
                    "+60 de dommages",
                    "+60 de soins",
                    "+500 en agilité",
                    "+500 en chance",
                    "+500 en force",
                    "+500 en intelligence",
                    "+60 en coups critiques",
                    "Enlève les envoûtements",
                    "+6 à la portée",
                    "Fait passer le tour suivant",
                    "PDV rendus : 5000"
                };
        }
    }
}