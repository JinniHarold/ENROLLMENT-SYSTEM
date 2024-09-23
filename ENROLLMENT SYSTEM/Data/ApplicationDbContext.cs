using Microsoft.EntityFrameworkCore;

namespace ENROLLMENT_SYSTEM.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
    }
}
