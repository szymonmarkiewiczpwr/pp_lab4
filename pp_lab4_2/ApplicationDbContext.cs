using Microsoft.EntityFrameworkCore;

namespace pp_lab4_2
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Models.Movie> Movies { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
