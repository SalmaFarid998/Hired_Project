using HiredProject.Domains;
using Microsoft.EntityFrameworkCore;

namespace HiredProject.DbContexts
{
    public class HiredDbContext : DbContext
    {
        public HiredDbContext(DbContextOptions options) : base(options)
        {
        }

        protected HiredDbContext()
        {
        }

        DbSet<Company> Companies { get; set; }
        DbSet<Review> Reviews { get; set; }
    }
}
