using CapstoneProject.ESN.Configuration;
using CapstoneProject.ESN.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CapstoneProject.ESN.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class ESNDbContextFactory : IDesignTimeDbContextFactory<ESNDbContext>
    {
        public ESNDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ESNDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(ESNConsts.ConnectionStringName)
            );

            return new ESNDbContext(builder.Options);
        }
    }
}