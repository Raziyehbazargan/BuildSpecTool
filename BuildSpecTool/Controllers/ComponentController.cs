using BuildSpecTool.Models;
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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Component details)
        {
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
            return RedirectToAction("Index","SiteManagement", new { id = details.EventId });

        }
    }
}