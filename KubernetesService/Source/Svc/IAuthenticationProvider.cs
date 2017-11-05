using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    /// <summary>
    /// Implements client authentication;
    /// </summary>
    public interface IAuthenticationProvider
    {
        IConfigurationProvider ConfigurationProvider { get; }

        /// <summary>
        /// Applying configuration to service client http handler.
        /// </summary>
        /// <param name="endPoint">Cluster endpoint</param>
        /// <param name="handler">Service client http handler</param>
        void ApplyConfiguration(Uri endPoint, WebRequestHandler handler);
    }
}
