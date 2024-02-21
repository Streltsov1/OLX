using Microsoft.AspNetCore.Mvc;
﻿using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace OLX.Controllers
{
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService favoriteService;

        public FavoriteController(IFavoriteService favoriteService)
        {
            this.favoriteService = favoriteService;
        }
        public IActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(favoriteService.GetAnnouncements());
        }

        public IActionResult Add(int id, string returnUrl)
        {
            favoriteService.Add(id);

            //ViewBag.ToastMessage = "Product was added to your cart!";
            TempData["ToastMessage"] = "Product was added to your cart!";

            return Redirect(returnUrl);
        }

        public IActionResult Remove(int id, string returnUrl)
        {
            TempData["ToastMessage"] = "Product was removed from your cart!";

            favoriteService.Remove(id);
            return Redirect(returnUrl);
        }
    }
}
