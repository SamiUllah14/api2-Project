using api2.Model;
using Microsoft.EntityFrameworkCore;

namespace api2.Data
{

    public class ComDbContext : DbContext
    {
        public ComDbContext(DbContextOptions<ComDbContext> options) : base(options)
        {
            // Additional constructor logic if needed
        }
        public DbSet<Comments> Comment { get; set; }
    }
}
