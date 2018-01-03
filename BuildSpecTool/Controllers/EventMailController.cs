﻿using BuildSpecTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace BuildSpecTool.Controllers
{
    public class EventMailController : Controller
    {
        private ApplicationDbContext _context;

        public EventMailController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: EventMail
        public ActionResult Index(int id)
        {
            var eventMails = _context.EventMails.Where(m => m.EventId == id).Include(m => m.Mail).Include(e => e.Event).ToList();
            return View(eventMails);
        }

        public ActionResult Save(EventMail details)
        {
            _context.EventMails.Add(details);
            _context.SaveChanges();
            return RedirectToAction("Index", "SiteManagement", new { id = details.EventId });
        }
    }
}