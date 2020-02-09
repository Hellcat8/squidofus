using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Squidofus.Models;
using Squidofus.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Squidofus.Controllers
{
    public class EquipementController : Controller
    {
        private readonly ILogger<EquipementController> _logger;
        private SquidofusContext _context;

        public EquipementController(ILogger<EquipementController> logger, SquidofusContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Equipement> stuff = _context.Equipement.Include(x => x.EquipementCondition).Include(x => x.EquipementEffect)
                                       .ThenInclude(x => x.IdTypeCaracteristiqueNavigation)
                                       .Include(x => x.IdTypeEquipementNavigation).ToList();
            return View(stuff);
        }
    }
}