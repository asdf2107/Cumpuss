using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cumpuss.Application
{
    public static class ConfigManager
    {
        private static IConfiguration? _Configuration;

        public static void Setup(IConfiguration? configuration)
        {
            if (_Configuration is not null) throw new InvalidOperationException();
            if (configuration is null) throw new ArgumentException("configuration can not be null.");

            _Configuration = configuration;
        }

        public static string GetValue(string key)
        {
            return _Configuration!.GetSection(key).Value;
        }
    }
}
