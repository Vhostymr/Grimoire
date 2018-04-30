using Grimoire.Data;
using Grimoire.Domain;
using Grimoire.Models.SpellCard;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Grimoire.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGrimoireContext _context;

        public HomeController(IGrimoireContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var spells = _context.Spells.Include(b => b.School).ToList();

            var model = new SpellViewModel
            {
                Spells = spells
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Spell model)
        {
            if (!ModelState.IsValid) return View();

            _context.Spells.Add(model);

            return View();
        }
    }
}