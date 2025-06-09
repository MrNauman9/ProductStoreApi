using Microsoft.EntityFrameworkCore;
using ProductStoreApi.Model;
using System.Collections.Generic;

namespace ProductStoreApi.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
