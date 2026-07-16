using Microsoft.EntityFrameworkCore;

namespace RetailInventory
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=RetailDB;Trusted_Connection=True;");
        }
    }
}
