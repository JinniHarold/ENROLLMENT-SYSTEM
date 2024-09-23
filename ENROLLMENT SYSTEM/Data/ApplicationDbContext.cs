using Microsoft.EntityFrameworkCore;
using ENROLLMENT_SYSTEM.Models.Entities;

namespace ENROLLMENT_SYSTEM.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<Students> StudentEntry { get; set; }
    }
}
