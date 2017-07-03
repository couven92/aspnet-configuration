using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Configuration
{
    public static class RegistryConfigurationExtensions
    {
        public static IConfigurationBuilder AddRegistryKey(this IConfigurationBuilder builder) => builder;
    }
}
