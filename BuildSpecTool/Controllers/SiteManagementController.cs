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
                AttendeeTypeViewModel = new AttendeeTypeViewModel {
                    AttendeeTypes = _context.Ref_AttendeeType.ToList(),
                    EventAttendeeTypes = _context.AttendeeType.Where(e => e.EventId == id)
                }
            };

            return View(viewModel);
        }

        //[HttpPost]
        //public ActionResult SaveComponent(Component details)
        //{
        //    var components = _context.EventComponent.Where(c => c.EventId == details.Event.Id).FirstOrDefault();

        //    if (components == null)
        //    {
        //        details.EventId = details.Event.Id;
        //        _context.EventComponent.Add(details);
        //    }
        //    else
        //    {
        //        TryUpdateModel(components);
        //    }

        //    _context.SaveChanges();
        //    return View("Index", "SiteManagement");
        //}
    }
}