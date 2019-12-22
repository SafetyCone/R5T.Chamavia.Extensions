using System;

using Microsoft.Extensions.Configuration;


namespace R5T.Chamavia.Extensions
{
    public static class ICommandBuilderExtensions
    {
        public static IConfigurationBuilder AddConfigurations(this IConfigurationBuilder configurationBuilder, Action<IConfigurationBuilder> action)
        {
            action(configurationBuilder);

            return configurationBuilder;
        }
    }
}
