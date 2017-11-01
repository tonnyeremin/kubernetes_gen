// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KubernetesService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ReplicationControllerSpec is the specification of a replication
    /// controller.
    /// </summary>
    public partial class Iok8sapicorev1ReplicationControllerSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ReplicationControllerSpec class.
        /// </summary>
        public Iok8sapicorev1ReplicationControllerSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ReplicationControllerSpec class.
        /// </summary>
        /// <param name="minReadySeconds">Minimum number of seconds for which a
        /// newly created pod should be ready without any of its container
        /// crashing, for it to be considered available. Defaults to 0 (pod
        /// will be considered available as soon as it is ready)</param>
        /// <param name="replicas">Replicas is the number of desired replicas.
        /// This is a pointer to distinguish between explicit zero and
        /// unspecified. Defaults to 1. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller</param>
        /// <param name="selector">Selector is a label query over pods that
        /// should match the Replicas count. If Selector is empty, it is
        /// defaulted to the labels present on the Pod template. Label keys and
        /// values that must match in order to be controlled by this
        /// replication controller, if empty defaulted to labels on Pod
        /// template. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</param>
        /// <param name="template">Template is the object that describes the
        /// pod that will be created if insufficient replicas are detected.
        /// This takes precedence over a TemplateRef. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</param>
        public Iok8sapicorev1ReplicationControllerSpec(int? minReadySeconds = default(int?), int? replicas = default(int?), IDictionary<string, string> selector = default(IDictionary<string, string>), Iok8sapicorev1PodTemplateSpec template = default(Iok8sapicorev1PodTemplateSpec))
        {
            MinReadySeconds = minReadySeconds;
            Replicas = replicas;
            Selector = selector;
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets minimum number of seconds for which a newly created
        /// pod should be ready without any of its container crashing, for it
        /// to be considered available. Defaults to 0 (pod will be considered
        /// available as soon as it is ready)
        /// </summary>
        [JsonProperty(PropertyName = "minReadySeconds")]
        public int? MinReadySeconds { get; set; }

        /// <summary>
        /// Gets or sets replicas is the number of desired replicas. This is a
        /// pointer to distinguish between explicit zero and unspecified.
        /// Defaults to 1. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Gets or sets selector is a label query over pods that should match
        /// the Replicas count. If Selector is empty, it is defaulted to the
        /// labels present on the Pod template. Label keys and values that must
        /// match in order to be controlled by this replication controller, if
        /// empty defaulted to labels on Pod template. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public IDictionary<string, string> Selector { get; set; }

        /// <summary>
        /// Gets or sets template is the object that describes the pod that
        /// will be created if insufficient replicas are detected. This takes
        /// precedence over a TemplateRef. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Iok8sapicorev1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Template != null)
            {
                Template.Validate();
            }
        }
    }
}
