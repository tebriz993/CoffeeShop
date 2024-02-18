using CoffeeShop.Models;
using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly CoffeeShopDbContext _context;
        public AboutUsController(CoffeeShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutUs? aboutUs = _context.AboutUs.FirstOrDefault();
            return View(aboutUs);
        }
    }
}
