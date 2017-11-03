using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    public interface IAuthenticationProvider
    {
        IConfigurationProvider ConfigurationProvider { get; }

        void ApplyConfiguration(WebRequestHandler handler);
    }
}
