using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.Configuration.Registry
{
    /// <summary>
    /// A Windows Registry based <see cref="ConfigurationProvider"/>.
    /// </summary>
    public class RegistryConfigurationProvider : ConfigurationProvider
    {
        public RegistryConfigurationProvider(RegistryConfigurationSource source)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public RegistryConfigurationSource Source { get; }

        private void Load(bool reload)
        {
            
        }
    }
}
