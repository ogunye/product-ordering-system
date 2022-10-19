using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using rhotechsolution.PersistenceData.ApplicationDbContext;

namespace rhotechsolution.WebApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlServerConnection"),
                b => b.MigrationsAssembly("rhotechsolution.WebApi"));

            return new RepositoryContext(builder.Options);
        }
    }
}
