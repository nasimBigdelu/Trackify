using System.Linq;
using System.Web.Mvc;
using Trackify.Models;
using Trackify.ViewModels;

namespace Trackify.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel
            {
                Categories = _context.Categories.ToList()
            };

            return View(viewModel);
        }
    }
}