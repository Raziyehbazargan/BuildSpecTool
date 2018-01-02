using BuildSpecTool.Models;
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

        // GET: EventAttendeeType
        public ActionResult Index()
        {
            var attendeTypes = _context.Ref_AttendeeType.ToList();
            return View(attendeTypes);
        }
    }
}