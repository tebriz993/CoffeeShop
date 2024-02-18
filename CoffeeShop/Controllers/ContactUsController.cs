using CoffeeShop.Models;
using CoffeeShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly CoffeeShopDbContext _context;
        public ContactUsController(CoffeeShopDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            ContactUs? contactUs = _context.ContactUs.FirstOrDefault();
            return View(contactUs);
        }
    }
}
