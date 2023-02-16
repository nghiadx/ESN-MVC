using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.ESN.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<ESNDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for ESNDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
