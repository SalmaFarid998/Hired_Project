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

        public DbSet<Company> Companies { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<WorkingPeriod> EmploymentHistories { get; set; }
    }
}
