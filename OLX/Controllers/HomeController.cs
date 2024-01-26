using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OLX.Data;
using OLX.Models;
using System.Diagnostics;

namespace OLX.Controllers
{
    public class HomeController : Controller
    {
        private readonly OLXDbContext context;
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger, OLXDbContext _context)
        {
            _logger = logger;
            context = _context;
        }
        public IActionResult Index()
        {
            var announcements = context.Announcements.Include(x => x.City).Include(x => x.Category).ToList();

            return View(announcements);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}