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
    /// DaemonSetSpec is the specification of a daemon set.
    /// </summary>
    public partial class Iok8sapiappsv1DaemonSetSpec
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapiappsv1DaemonSetSpec
        /// class.
        /// </summary>
        public Iok8sapiappsv1DaemonSetSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapiappsv1DaemonSetSpec
        /// class.
        /// </summary>
        /// <param name="template">An object that describes the pod that will
        /// be created. The DaemonSet will create exactly one copy of this pod
        /// on every node that matches the template's node selector (or on
        /// every node if no node selector is specified). More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template</param>
        /// <param name="minReadySeconds">The minimum number of seconds for
        /// which a newly created DaemonSet pod should be ready without any of
        /// its container crashing, for it to be considered available. Defaults
        /// to 0 (pod will be considered available as soon as it is
        /// ready).</param>
        /// <param name="revisionHistoryLimit">The number of old history to
        /// retain to allow rollback. This is a pointer to distinguish between
        /// explicit zero and not specified. Defaults to 10.</param>
        /// <param name="selector">A label query over pods that are managed by
        /// the daemon set. Must match in order to be controlled. If empty,
        /// defaulted to labels on Pod template. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors</param>
        /// <param name="updateStrategy">An update strategy to replace existing
        /// DaemonSet pods with new pods.</param>
        public Iok8sapiappsv1DaemonSetSpec(Iok8sapicorev1PodTemplateSpec template, int? minReadySeconds = default(int?), int? revisionHistoryLimit = default(int?), Iok8sapimachinerypkgapismetav1LabelSelector selector = default(Iok8sapimachinerypkgapismetav1LabelSelector), Iok8sapiappsv1DaemonSetUpdateStrategy updateStrategy = default(Iok8sapiappsv1DaemonSetUpdateStrategy))
        {
            MinReadySeconds = minReadySeconds;
            RevisionHistoryLimit = revisionHistoryLimit;
            Selector = selector;
            Template = template;
            UpdateStrategy = updateStrategy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum number of seconds for which a newly
        /// created DaemonSet pod should be ready without any of its container
        /// crashing, for it to be considered available. Defaults to 0 (pod
        /// will be considered available as soon as it is ready).
        /// </summary>
        [JsonProperty(PropertyName = "minReadySeconds")]
        public int? MinReadySeconds { get; set; }

        /// <summary>
        /// Gets or sets the number of old history to retain to allow rollback.
        /// This is a pointer to distinguish between explicit zero and not
        /// specified. Defaults to 10.
        /// </summary>
        [JsonProperty(PropertyName = "revisionHistoryLimit")]
        public int? RevisionHistoryLimit { get; set; }

        /// <summary>
        /// Gets or sets a label query over pods that are managed by the daemon
        /// set. Must match in order to be controlled. If empty, defaulted to
        /// labels on Pod template. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        /// </summary>
        [JsonProperty(PropertyName = "selector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector Selector { get; set; }

        /// <summary>
        /// Gets or sets an object that describes the pod that will be created.
        /// The DaemonSet will create exactly one copy of this pod on every
        /// node that matches the template's node selector (or on every node if
        /// no node selector is specified). More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public Iok8sapicorev1PodTemplateSpec Template { get; set; }

        /// <summary>
        /// Gets or sets an update strategy to replace existing DaemonSet pods
        /// with new pods.
        /// </summary>
        [JsonProperty(PropertyName = "updateStrategy")]
        public Iok8sapiappsv1DaemonSetUpdateStrategy UpdateStrategy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Template == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Template");
            }
            if (Template != null)
            {
                Template.Validate();
            }
        }
    }
}
