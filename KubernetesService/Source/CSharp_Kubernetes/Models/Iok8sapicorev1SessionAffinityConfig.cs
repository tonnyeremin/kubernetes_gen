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
    /// SessionAffinityConfig represents the configurations of session
    /// affinity.
    /// </summary>
    public partial class Iok8sapicorev1SessionAffinityConfig
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1SessionAffinityConfig class.
        /// </summary>
        public Iok8sapicorev1SessionAffinityConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1SessionAffinityConfig class.
        /// </summary>
        /// <param name="clientIP">clientIP contains the configurations of
        /// Client IP based session affinity.</param>
        public Iok8sapicorev1SessionAffinityConfig(Iok8sapicorev1ClientIPConfig clientIP = default(Iok8sapicorev1ClientIPConfig))
        {
            ClientIP = clientIP;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets clientIP contains the configurations of Client IP
        /// based session affinity.
        /// </summary>
        [JsonProperty(PropertyName = "clientIP")]
        public Iok8sapicorev1ClientIPConfig ClientIP { get; set; }

    }
}
