using BuildSpecTool.Models;
using BuildSpecTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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

        [HttpGet]
        public ActionResult Index(int id)
        {
            AttendeeTypeViewModel viewModel = new AttendeeTypeViewModel
            {
                RefAttendeeTypes = _context.Ref_AttendeeType.ToList(),
                EventAttendeeTypes = _context.AttendeeType.Where(c => c.EventId == id).Include(e => e.AttendeeType).ToList(),
                EventAttendeeType = new EventAttendeeType
                {
                    EventId = id
                }
            };
               
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(AttendeeTypeViewModel details)
        {
            _context.AttendeeType.Add(details.EventAttendeeType);
            _context.SaveChanges();
            return View("Index");
        }
    }
}