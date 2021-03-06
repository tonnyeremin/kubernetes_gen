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
    /// ClientIPConfig represents the configurations of Client IP based session
    /// affinity.
    /// </summary>
    public partial class Iok8sapicorev1ClientIPConfig
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1ClientIPConfig
        /// class.
        /// </summary>
        public Iok8sapicorev1ClientIPConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1ClientIPConfig
        /// class.
        /// </summary>
        /// <param name="timeoutSeconds">timeoutSeconds specifies the seconds
        /// of ClientIP type session sticky time. The value must be &gt;0
        /// &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP".
        /// Default value is 10800(for 3 hours).</param>
        public Iok8sapicorev1ClientIPConfig(int? timeoutSeconds = default(int?))
        {
            TimeoutSeconds = timeoutSeconds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets timeoutSeconds specifies the seconds of ClientIP type
        /// session sticky time. The value must be &amp;gt;0 &amp;amp;&amp;amp;
        /// &amp;lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default
        /// value is 10800(for 3 hours).
        /// </summary>
        [JsonProperty(PropertyName = "timeoutSeconds")]
        public int? TimeoutSeconds { get; set; }

    }
}
