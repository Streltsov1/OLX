using Microsoft.AspNetCore.Mvc;
using OLX.Data;
using OLX.Data.Entities;

namespace OLX.Controllers
{
    public class AnnouncementsController : Controller
    {
        private readonly OLXDbContext context;

        public AnnouncementsController(OLXDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var announcements = context.Announcements.ToList();

            return View(announcements);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Announcement model)
        {
            context.Announcements.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var announcement = context.Announcements.Find(id);
            if (announcement == null) return NotFound();

            context.Announcements.Remove(announcement);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
