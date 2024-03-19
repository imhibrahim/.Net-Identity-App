using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity_app.Data
{
    public class ApplicationDbContext :IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUsers  { get; set; }
    }
}
