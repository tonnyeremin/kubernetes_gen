// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KubernetesService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Projection that may be projected along with other supported volume
    /// types
    /// </summary>
    public partial class Iok8sapicorev1VolumeProjection
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1VolumeProjection
        /// class.
        /// </summary>
        public Iok8sapicorev1VolumeProjection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1VolumeProjection
        /// class.
        /// </summary>
        /// <param name="configMap">information about the configMap data to
        /// project</param>
        /// <param name="downwardAPI">information about the downwardAPI data to
        /// project</param>
        /// <param name="secret">information about the secret data to
        /// project</param>
        public Iok8sapicorev1VolumeProjection(Iok8sapicorev1ConfigMapProjection configMap = default(Iok8sapicorev1ConfigMapProjection), Iok8sapicorev1DownwardAPIProjection downwardAPI = default(Iok8sapicorev1DownwardAPIProjection), Iok8sapicorev1SecretProjection secret = default(Iok8sapicorev1SecretProjection))
        {
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets information about the configMap data to project
        /// </summary>
        [JsonProperty(PropertyName = "configMap")]
        public Iok8sapicorev1ConfigMapProjection ConfigMap { get; set; }

        /// <summary>
        /// Gets or sets information about the downwardAPI data to project
        /// </summary>
        [JsonProperty(PropertyName = "downwardAPI")]
        public Iok8sapicorev1DownwardAPIProjection DownwardAPI { get; set; }

        /// <summary>
        /// Gets or sets information about the secret data to project
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public Iok8sapicorev1SecretProjection Secret { get; set; }

    }
}
