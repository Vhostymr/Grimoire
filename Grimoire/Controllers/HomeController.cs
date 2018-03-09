using Grimoire.Data;
using Grimoire.Data.DataModels;
using System.Web.Mvc;

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
            return View();
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