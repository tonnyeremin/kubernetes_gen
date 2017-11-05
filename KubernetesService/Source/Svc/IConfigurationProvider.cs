using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    /// <summary>
    /// Implements reading Kubernetes client configuration
    /// </summary>
    public interface IConfigurationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Client cofiguration</returns>
        CKubernatesConfig GetConfiguration();
    }
}
