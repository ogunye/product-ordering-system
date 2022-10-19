using Microsoft.EntityFrameworkCore;
using rhotechsolution.Application.Contracts;
using rhotechsolution.LogServices;
using rhotechsolution.PersistenceData;
using rhotechsolution.PersistenceData.ApplicationDbContext;

namespace rhotechsolution.WebApi.Extensions
{
    public static class ServiceRegistration
    {
        public static void ConfigureCors(this IServiceCollection services)=>
            services.AddCors(option =>
            {
                option.AddPolicy("CorPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(option => { });

        public static void ConfigureLogService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        //ConfigureServiceManager goes Here

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlServerConnection")));
    }
}
