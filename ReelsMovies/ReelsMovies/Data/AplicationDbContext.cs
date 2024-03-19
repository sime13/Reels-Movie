using Microsoft.EntityFrameworkCore;

namespace ReelsMovies.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<  >  { get; set; }
    }

}
