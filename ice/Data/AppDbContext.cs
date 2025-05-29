using Microsoft.EntityFrameworkCore;
using ice.Models;
using System.Collections.Generic;

namespace ice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Products> Products { get; set; }
    }
}
