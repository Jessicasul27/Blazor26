using Blazor26.Models.Models;
using Microsoft.EntityFrameworkCore;


namespace Blazor26.DataAccess.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) 
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Sales> Sales { get; set; }

    }
}
