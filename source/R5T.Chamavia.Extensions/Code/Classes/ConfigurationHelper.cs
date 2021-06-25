using System;

using Microsoft.Extensions.Configuration;


namespace R5T.Chamavia
{
    public static class ConfigurationHelper
    {
        public const string NotFoundValue = null;


        public static bool ValueWasFound(string value)
        {
            var output = value != ConfigurationHelper.NotFoundValue;
            return output;
        }

        public static bool ValueNotFound(string value)
        {
            var output = value == ConfigurationHelper.NotFoundValue;
            return output;
        }

        public static IConfiguration GetEmptyConfiguration()
        {
            var emptyConfiguration = new ConfigurationBuilder()
                .Build();

            return emptyConfiguration;
        }
    }
}
