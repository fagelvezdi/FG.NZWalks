using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NZWalks.Application.BusinessLogic;
using NZWalks.Application.Mapping_Profiles;
using NZWalks.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.BusinessLogic
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServiceRegistration(this IServiceCollection services, IConfiguration configuration) 
        { 
        
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IWalkService, WalkService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IImageService, ImageService>();

            services.AddHttpContextAccessor();

            services.AddPersistenceServiceRegistration(configuration);
            services.AddAutoMapper(typeof(RegionProfile));
            services.AddAutoMapper(typeof(WalkProfile));
            services.AddAutoMapper(typeof(DifficultyProfile));
            services.AddAutoMapper(typeof(ImageProfile));

            return services;
        }
    }
}
