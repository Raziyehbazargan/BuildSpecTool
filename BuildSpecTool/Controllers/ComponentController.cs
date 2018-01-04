using BuildSpecTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BuildSpecTool.Controllers
{
    [Authorize]
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
        [HttpGet]
        public ActionResult Index(int id)
        {
            var component = _context.EventComponent.Where(c => c.EventId == id).FirstOrDefault();
            ViewBag.EventName = _context.Event.Where(e => e.Id == id).FirstOrDefault().Name;
            return View(component?? new Component { EventId = id});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Component details)
        {
            if (!ModelState.IsValid)
            {
                var error = ModelState.Where(e => e.Value.Errors.Count > 0).ToArray();
                return View("Index");
            }

            var components = _context.EventComponent.Where(c => c.EventId == details.EventId).FirstOrDefault();

            if (components == null)
            {
                _context.EventComponent.Add(details);
            }
            else
            {
                TryUpdateModel(components);
            }

            _context.SaveChanges();
            return View("Index");
        }
    }
}