using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDatasetLibrary.Core.Services;
using UserDatasetLibrary.Core.Services.Interfaces;

namespace UserDatasetLibrary.Core.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection RegisterTransientCrudServices(this IServiceCollection services)
        {
            services.AddTransient<IFotoService, FotoService>()
                .AddTransient<IUserService, UserService>();
            return services;
            //services.AddTransient<IUserService, UserService>();
            //return services;
        }
    }
}
