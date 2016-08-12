using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
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

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel
            {
                Categories = _context.Categories.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(EventFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _context.Categories.ToList();
                return View("Create", viewModel);
            }


            var ev = new Event
            {
                CompanyId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Venue = viewModel.Venue
            };


            _context.Events.Add(ev);
            _context.SaveChanges();


            return RedirectToAction("Index", "Home");
        }
    }
}