// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KubernetesService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ObjectMetricStatus indicates the current value of a metric describing a
    /// kubernetes object (for example, hits-per-second on an Ingress object).
    /// </summary>
    public partial class Iok8sapiautoscalingv2beta1ObjectMetricStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiautoscalingv2beta1ObjectMetricStatus class.
        /// </summary>
        public Iok8sapiautoscalingv2beta1ObjectMetricStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiautoscalingv2beta1ObjectMetricStatus class.
        /// </summary>
        /// <param name="currentValue">currentValue is the current value of the
        /// metric (as a quantity).</param>
        /// <param name="metricName">metricName is the name of the metric in
        /// question.</param>
        /// <param name="target">target is the described Kubernetes
        /// object.</param>
        public Iok8sapiautoscalingv2beta1ObjectMetricStatus(string currentValue, string metricName, Iok8sapiautoscalingv2beta1CrossVersionObjectReference target)
        {
            CurrentValue = currentValue;
            MetricName = metricName;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets currentValue is the current value of the metric (as a
        /// quantity).
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public string CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets metricName is the name of the metric in question.
        /// </summary>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or sets target is the described Kubernetes object.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public Iok8sapiautoscalingv2beta1CrossVersionObjectReference Target { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CurrentValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrentValue");
            }
            if (MetricName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricName");
            }
            if (Target == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Target");
            }
            if (Target != null)
            {
                Target.Validate();
            }
        }
    }
}
