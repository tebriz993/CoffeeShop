using Microsoft.EntityFrameworkCore;
using CoffeeShop.Models;

namespace CoffeeShop.Data
{
    public class CoffeeShopDbContext:DbContext
    {
        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options):base(options)
        {
            
        }
        
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<Services> Services { get; set; }
    }
}
