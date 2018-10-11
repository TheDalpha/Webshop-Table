using Group13.Webshop.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Group13.Webshop.Infrastructure.Data
{
    public class WebshopAppContext : DbContext
    {
        public WebshopAppContext(DbContextOptions<WebshopAppContext> opt) : base(opt) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Kart> Karts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(p => p.ShoppingKart).WithOne(k => k.User);
            
            modelBuilder.Entity<Kart>().HasMany(k => k.Products);
        }
    }
}
