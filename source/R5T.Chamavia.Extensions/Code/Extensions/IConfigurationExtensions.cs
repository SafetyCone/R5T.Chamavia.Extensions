using System;

using Microsoft.Extensions.Configuration;

using R5T.Chamavia;
using R5T.Magyar;


namespace System
{
    public static class IConfigurationExtensions
    {
        public static WasFound<string> GetValueOkIfNotExists(this IConfiguration configuration, string key)
        {
            var value = configuration[key];

            var exists = ConfigurationHelper.ValueWasFound(value);

            var wasFound = WasFound.From(exists, value);
            return wasFound;
        }

        public static string GetRequiredValue(this IConfiguration configuration, string key)
        {
            var value = configuration[key];

            if(ConfigurationHelper.ValueNotFound(value))
            {
                throw new ArgumentException($"Configuration value not found for key '{key}'.");
            }

            return value;
        }
    }
}
