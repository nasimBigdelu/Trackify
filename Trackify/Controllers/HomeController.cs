using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Trackify.Models;

namespace Trackify.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcomingEvents = _context.Events
                .Include(g => g.Category)
                .Include(g => g.Company)
                .Where(g => g.DateTime > DateTime.Now);

            return View(upcomingEvents);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}