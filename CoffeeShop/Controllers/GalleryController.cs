using CoffeeShop.Models;
using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class GalleryController : Controller
    {
        private readonly CoffeeShopDbContext _context;
        public GalleryController(CoffeeShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Gallery> gallery = _context.Gallery.ToList();
            return View(gallery);
        }
    }
}
