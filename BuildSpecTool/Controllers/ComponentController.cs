using BuildSpecTool.Models;
using BuildSpecTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildSpecTool.Controllers
{
    public class ComponentController : Controller
    {
        private ApplicationDbContext _context;
        public ComponentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Component
        public ActionResult Index(int id)
        {
            var eventComponents = _context.EventComponent.FirstOrDefault(c => c.EventId == id);
            var currentEvent = _context.Event.FirstOrDefault(e => e.Id == id);

            var viewModel = new ComponentViewModel
            {
                Event = currentEvent,
                Component = eventComponents
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(ComponentViewModel details)
        {

            var eventComponents = _context.EventComponent.Where(c => c.EventId == details.Event.Id).FirstOrDefault();

            if (eventComponents == null)
            {
                details.Component.EventId = details.Event.Id;
                _context.EventComponent.Add(details.Component);
            }
            else
            {
                TryUpdateModel(eventComponents);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}