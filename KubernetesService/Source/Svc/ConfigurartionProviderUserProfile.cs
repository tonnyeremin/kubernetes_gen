﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using KubernetesService;

namespace KubernetesService
{
    public class CConfigurartionProviderUserProfile : IConfigurationProvider
    {
        public CConfigurartionProviderUserProfile()
        {

        }

        public CKubernatesConfig GetConfiguration()
        {
            try
            {
                var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                var kubernetesUserCfg = string.Format(@"{0}\.kube\config", userDir);
                using (FileStream stream = File.OpenRead(kubernetesUserCfg))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string cfgStr = reader.ReadToEnd();
                        return CKubernatesConfig.Desirialize(cfgStr);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to read configuration from current user profile", ex);
            }
        }

       
    }
}
