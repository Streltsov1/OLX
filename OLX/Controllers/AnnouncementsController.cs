using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using DataAccess.Data.Entities;

namespace OLX.Controllers
{
    public class AnnouncementsController : Controller
    {
        private readonly OLXDbContext context;

        public AnnouncementsController(OLXDbContext context)
        {
            this.context = context;
        }
        private void LoadData()
        {
            ViewBag.Categories = new SelectList(context.Categories.ToList(), nameof(Category.Id), nameof(Category.Name));
            ViewBag.Cities = new SelectList(context.Cities.ToList(), nameof(City.Id), nameof(City.Name));
        }
        public IActionResult Index()
        {
            var announcements = context.Announcements.Include(x => x.Category).Include(x => x.City).ToList();

            return View(announcements);
        }
        public IActionResult Create()
        {
            LoadData();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Announcement model)
        {
            LoadData();
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
        public IActionResult Edit(int id)
        {
            var announcement = context.Announcements.Find(id);
            if (announcement == null) return NotFound();
            LoadData();
            return View(announcement);
        }

        [HttpPost]
        public IActionResult Edit(Announcement model)
        {
            if (!ModelState.IsValid)
            {
                LoadData();
                return View(model);
            }

            context.Announcements.Update(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var announcement = context.Announcements.Find(id);

            if (announcement == null) return NotFound();
            context.Entry(announcement).Reference(x => x.Category).Load();

            return View(announcement);
        }
    }
}
