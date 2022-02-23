using Cumpuss.Application.Exceptions;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Cumpuss.Application.Holders
{
    public static class ConfigHolder
    {
        private static IConfiguration _Configuration;

        public static void Setup(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public static string GetValue(string key)
        {
            return _Configuration!.GetSection(key).Value;
        }

        public static int GetIntValue(string key)
        {
            string value = _Configuration.GetSection(key).Value;
            if (string.IsNullOrEmpty(value)) throw new ConfigException();

            return int.Parse(value);
        }

        public static bool GetBoolValue(string key)
        {
            string value = _Configuration.GetSection(key).Value;
            return bool.Parse(value);
        }
    }
}
