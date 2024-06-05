using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HaberPortalı.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> Newss { get; set; }

        public DbSet<Author> Authors { get; set; }


    }
}
