using Microsoft.EntityFrameworkCore;
using ProductsManagement.Models;

namespace ProductsManagement.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");

    }
}
