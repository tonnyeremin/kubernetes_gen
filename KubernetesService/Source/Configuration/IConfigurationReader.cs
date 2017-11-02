using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KubernetesService
{
    public interface IConfigurationReader
    {
        CKubernatesConfig Read();
    }
}
