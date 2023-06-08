using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RedisCacheUsage.Domain;

namespace RedisCacheUsage.Infrastracture
{
    public class Context : DbContext
    {
        

        public Context(DbContextOptions<Context> options) : base(options) { }
       

        public DbSet<Product> Product { get; set; }

    }
}