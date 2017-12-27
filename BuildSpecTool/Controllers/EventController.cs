using BuildSpecTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BuildSpecTool.ViewModels;

namespace BuildSpecTool.Controllers
{
    public class EventController : Controller
    {
        private ApplicationDbContext _context;

        public EventController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Event
        public ActionResult Index()
        {
            var events = _context.Event.Include(e => e.Client).Include(e => e.Team).ToList();
            return View(events);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var clients = _context.Ref_Client.ToList();
            var teams = _context.Ref_Team.ToList();
            var viewModel = new EventViewModel
            {
                Clients = clients,
                Teams = teams
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(EventViewModel details)
        {

            return RedirectToAction("Index");
        }
    }
}