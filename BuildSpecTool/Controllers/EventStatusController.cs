using BuildSpecTool.Models;
using BuildSpecTool.Models.ReferenceModels;
using BuildSpecTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace BuildSpecTool.Controllers
{
    public class EventStatusController : Controller
    {
        private ApplicationDbContext _context;
        public EventStatusController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public ActionResult Index(int id)
        {
            StatusViewModel viewModel = new StatusViewModel
            {
                RefStatus = _context.Ref_Status.ToList(),
                EventStatusList = _context.EventStatus.Where(c => c.EventId == id).Include(e => e.Status).ToList(),
                EventStatus = new EventStatus
                {
                    EventId = id
                }
            };

            return View(viewModel);
        }

        public ActionResult Save(EventStatus details)
        {

            return View();
        }
    }
}