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
    public class RessourceController : Controller
    {
        private readonly ILogger<RessourceController> _logger;
        private SquidofusContext _context;

        public RessourceController(SquidofusContext context, ILogger<RessourceController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Ressource> ressources = _context.Ressource.Include(x => x.IdTypeRessourceNavigation)
                                                            .Include(x => x.RessourceEffect).ToList();

            return View(ressources);
        }
    }
}