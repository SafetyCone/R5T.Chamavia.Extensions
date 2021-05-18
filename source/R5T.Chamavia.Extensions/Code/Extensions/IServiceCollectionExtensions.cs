using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


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

        /// <summary>
        /// The standard way of adding an <see cref="IConfiguration"/> instance as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IConfiguration> AddConfigurationAction(this IServiceCollection services, IConfiguration configuration)
        {
            var serviceAction = ServiceAction.New<IConfiguration>(() => services.AddConfiguration(configuration));
            return serviceAction;
        }
    }
}
