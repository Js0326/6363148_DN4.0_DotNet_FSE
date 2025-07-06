using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventoryApp.Data

{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RetailInventoryDb;Trusted_Connection=True;Encrypt=False;");



        }
    }
}
