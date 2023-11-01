using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NZWalks.Application.DataAccess;
using NZWalks.Persistence.DatabaseContext;
using NZWalks.Persistence.Repository;


namespace NZWalks.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServiceRegistration(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<NZWalksDbContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("NZWalksDBConnectionString"));
                //options.UseCosmos("https://localhost:8081", "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==", "NZWalks_DB");
                //options.UseInMemoryDatabase("NZWalks_DB");
            });

            services.AddDbContext<NZWalksAuthDbContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("NZWalksAuthDBConnectionString"));
            });

            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IWalkRepository, WalkRepository>();
            services.AddScoped<IImageRepository, LocalImageRepository>();

            return services;
        }
    }
}
