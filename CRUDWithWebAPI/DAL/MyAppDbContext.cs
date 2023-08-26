using CRUDWithWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithWebAPI.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
