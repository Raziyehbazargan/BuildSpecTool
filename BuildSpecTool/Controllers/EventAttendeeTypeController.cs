using BuildSpecTool.Models;
using BuildSpecTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildSpecTool.Controllers
{
    public class EventAttendeeTypeController : Controller
    {
        private ApplicationDbContext _context;
        public EventAttendeeTypeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Save(EventAttendeeType details)
        {
            _context.AttendeeType.Add(details);
            _context.SaveChanges();
            return RedirectToAction("Index", "SiteManagement", new { id = details.EventId });
        }
    }
}