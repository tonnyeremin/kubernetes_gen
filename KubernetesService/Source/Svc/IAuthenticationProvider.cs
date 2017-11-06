using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace KubernetesService
{
    /// <summary>
    /// Implements client authentication;
    /// </summary>
    public interface IAuthenticationProvider
    {
        IConfigurationProvider ConfigurationProvider { get; }

        void ApplyConfiguration(Uri endPoint, WebRequestHandler handler);
    }
}
