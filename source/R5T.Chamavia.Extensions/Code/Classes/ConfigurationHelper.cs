using System;

using Microsoft.Extensions.Configuration;


namespace R5T.Chamavia
{
    public static class ConfigurationHelper
    {
        public static IConfiguration GetEmptyConfiguration()
        {
            var emptyConfiguration = new ConfigurationBuilder()
                .Build();

            return emptyConfiguration;
        }
    }
}
