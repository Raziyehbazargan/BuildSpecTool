using BuildSpecTool.Models;
using BuildSpecTool.ViewModels;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;


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
        public ActionResult Index(int id)
        {
            var viewModel = new ManagementViewModel
            {
                Component = _context.EventComponent.Include(e => e.Event).FirstOrDefault(c => c.EventId == id)
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save(Component details)
        {
            var components = _context.EventComponent.Where(c => c.EventId == details.Event.Id).FirstOrDefault();

            if (components == null)
            {
                details.EventId = details.Event.Id;
                _context.EventComponent.Add(details);
            }
            else
            {
                TryUpdateModel(components);
            }

            _context.SaveChanges();
            return View("Index");
        }
    }
}