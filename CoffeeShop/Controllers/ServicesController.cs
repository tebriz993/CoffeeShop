using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ServicesController : Controller
    {
        private readonly CoffeeShopDbContext _context;
        public ServicesController(CoffeeShopDbContext context)
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            List<Services> services = _context.Services.ToList();
            return View(services);
        }
    }
}
