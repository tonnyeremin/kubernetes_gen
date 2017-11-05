# .Net Kuberentes API

| .Net          | Platform           | State  |
| ------------- |:-------------:| -----:|
| 4.5.2      | x64 | ![Build status](https://ci.appveyor.com/api/projects/status/k3l5hs99umx2kmbl?svg=true) |

## Instalation

###### Package Manager
```Install-Package KubernetesService```
###### .Net Cli
```dotnet add package KubernetesService```
###### Packet Cli
```paket add KubernetesService```

## Code usage

``` csharp
//Creating user configuration provider
IConfigurationProvider confProvider = new CConfigurartionProviderUserProfile();

//Creating authentication provider
IAuthenticationProvider authProv = new CSSLAuthenticationProvider(confProvider);

//Creating service instance and connecting
CKubernetesService service = CKubernetesService.Connect(new Uri("https://<you_cluster_here>"), authProv);

var retVal = service.Service.ListAppsV1beta1NamespacedDeployment("default");

service.Dispose()
 ```

## Extending

Current version implements common authentification scenario. 
1) Reading configuration from %USERPROFILE%\.kube\config
2) Establishing a SSL connection to REST API endpoint 

For extending authentification functionality you have to implement two interfaces
1) Reading client configuration (ex. file, http,)
``` csharp
    public interface IConfigurationProvider
    {
        CKubernatesConfig GetConfiguration();
    }
``` 
2) Applying configuration to underlying HttpClientHandler. 
   Kubernetes offcially support SSL/TLS, user\password pair, OAuth token 
   Currently implemented SSL/TLS in this realese. Other scenarios planned for future
``` csharp
//
    public interface IAuthenticationProvider
    {
        IConfigurationProvider ConfigurationProvider { get; }
        
        void ApplyConfiguration(Uri endPoint, WebRequestHandler handler);
    }
```
 *Note: parameter Uri endPoint have exactly match cluser endpoint for configuration*
 
 ##support

All question you can address to project's [mailing list](https://groups.google.com/d/forum/net-kubernetes-api-mailing-list) 



