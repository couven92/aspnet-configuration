using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Configuration.Registry
{
    public class RegistryConfigurationSource : IConfigurationSource
    {
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new RegistryConfigurationProvider();
        }
    }
}
