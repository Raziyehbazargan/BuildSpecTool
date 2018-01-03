using BuildSpecTool.Models.ReferenceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildSpecTool.Controllers
{
    public class EventStatusController : Controller
    {
        // GET: EventStatus
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Save(EventStatus details)
        {

            return View();
        }
    }
}