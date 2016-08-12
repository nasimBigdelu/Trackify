using System;
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

            var ev = new Event
            {
                CompanyId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                CategoryId = viewModel.Category,
                Venue = viewModel.Venue
            };


            _context.Events.Add(ev);
            _context.SaveChanges();


            return RedirectToAction("Index", "Home");
        }
    }
}