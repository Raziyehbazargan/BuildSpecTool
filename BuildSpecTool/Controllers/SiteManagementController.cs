using BuildSpecTool.Models;
using BuildSpecTool.ViewModels;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;


namespace BuildSpecTool.Controllers
{
    public class SiteManagementController : Controller
    {
        private ApplicationDbContext _context;
        public SiteManagementController()
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
            Component component = _context.EventComponent.FirstOrDefault(c => c.EventId == id);
            var viewModel = new ManagementViewModel
            {
                Component = component ?? new Component
                {
                    EventId = id
                },
                EventAttendeeType = new EventAttendeeType
                {
                    EventId = id
                },
                EventStatus = new Models.ReferenceModels.EventStatus
                {
                    EventId = id
                },
                EventPage = new EventPage
                {
                    EventId = id,
                    SitePageList = _context.Ref_Page.ToList()

                },
                EventMail = new EventMail
                {
                    EventId = id,
                    MailList = _context.Ref_Mail.ToList()
                },
                Event = new Event
                {
                    Id = id
                }
            };

            return View(viewModel);
        }
    }
}