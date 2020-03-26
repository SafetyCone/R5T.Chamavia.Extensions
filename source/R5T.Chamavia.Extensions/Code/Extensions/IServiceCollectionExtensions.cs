using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace R5T.Chamavia
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// The standard way of adding an <see cref="IConfiguration"/> instance as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);

            return services;
        }
    }
}
