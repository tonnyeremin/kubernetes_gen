using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Rest;

namespace KubernetesService
{
    public enum EVersion
    {
        Undefined = 0,
        V1 = 1
    }

    public class CKubernetesService : IDisposable
    {
        private readonly WebRequestHandler _handler;
        private readonly IAuthenticationProvider _authenticationProvider;

        private IKubernetes _serviceImpl;
        private EVersion _version;

        private CKubernetesService(IAuthenticationProvider authenticationProvider)
        {
            _handler = new WebRequestHandler();
            _authenticationProvider = authenticationProvider;
        }

        public static CKubernetesService Connect(Uri endpoint, IAuthenticationProvider authenticationProvider)
        {
            try
            {
                CKubernetesService service = new CKubernetesService(authenticationProvider);
                service.Connect(endpoint);
                return service;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Unbale to connect to API service: {0}", endpoint.AbsoluteUri), ex);
            }
        }

        public IKubernetes Service
        {
            get { return _serviceImpl; }
        }

        public EVersion Version
        {
            get { return _version; }
        }

        private void Connect(Uri endpoint)
        {
            _authenticationProvider.ApplyConfiguration(endpoint, _handler);
            _serviceImpl = new Kubernetes(endpoint, _handler, new JsonDelegatingHandler());
            _version = GetVersion(_serviceImpl);


        }

        private EVersion GetVersion(IKubernetes serviceImpl)
        {
            try
            {
                var version = serviceImpl.GetAPIVersions();
                switch (version.ApiVersion)
                {
                    case "v1":
                        return EVersion.V1;
                    default:
                        return EVersion.Undefined;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get service version.", ex);
            }
        }

        public void Dispose()
        {
            _serviceImpl.Dispose();
            _handler.Dispose();
        }


    }

    public class JsonDelegatingHandler : DelegatingHandler
    {

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            if (request.Content != null)
            {
                request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                request.Content = new StringContent(request.Content.ToString(), Encoding.UTF8,
                    "application/json");
            }
            return base.SendAsync(request, cancellationToken);

        }


    }

}
