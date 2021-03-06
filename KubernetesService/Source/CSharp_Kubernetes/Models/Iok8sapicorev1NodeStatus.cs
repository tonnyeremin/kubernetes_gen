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
    /// NodeStatus is information about the current status of a node.
    /// </summary>
    public partial class Iok8sapicorev1NodeStatus
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1NodeStatus class.
        /// </summary>
        public Iok8sapicorev1NodeStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1NodeStatus class.
        /// </summary>
        /// <param name="addresses">List of addresses reachable to the node.
        /// Queried from cloud provider, if available. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#addresses</param>
        /// <param name="allocatable">Allocatable represents the resources of a
        /// node that are available for scheduling. Defaults to
        /// Capacity.</param>
        /// <param name="capacity">Capacity represents the total resources of a
        /// node. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity</param>
        /// <param name="conditions">Conditions is an array of current observed
        /// node conditions. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#condition</param>
        /// <param name="daemonEndpoints">Endpoints of daemons running on the
        /// Node.</param>
        /// <param name="images">List of container images on this node</param>
        /// <param name="nodeInfo">Set of ids/uuids to uniquely identify the
        /// node. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#info</param>
        /// <param name="phase">NodePhase is the recently observed lifecycle
        /// phase of the node. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#phase The field is
        /// never populated, and now is deprecated.</param>
        /// <param name="volumesAttached">List of volumes that are attached to
        /// the node.</param>
        /// <param name="volumesInUse">List of attachable volumes in use
        /// (mounted) by the node.</param>
        public Iok8sapicorev1NodeStatus(IList<Iok8sapicorev1NodeAddress> addresses = default(IList<Iok8sapicorev1NodeAddress>), IDictionary<string, string> allocatable = default(IDictionary<string, string>), IDictionary<string, string> capacity = default(IDictionary<string, string>), IList<Iok8sapicorev1NodeCondition> conditions = default(IList<Iok8sapicorev1NodeCondition>), Iok8sapicorev1NodeDaemonEndpoints daemonEndpoints = default(Iok8sapicorev1NodeDaemonEndpoints), IList<Iok8sapicorev1ContainerImage> images = default(IList<Iok8sapicorev1ContainerImage>), Iok8sapicorev1NodeSystemInfo nodeInfo = default(Iok8sapicorev1NodeSystemInfo), string phase = default(string), IList<Iok8sapicorev1AttachedVolume> volumesAttached = default(IList<Iok8sapicorev1AttachedVolume>), IList<string> volumesInUse = default(IList<string>))
        {
            Addresses = addresses;
            Allocatable = allocatable;
            Capacity = capacity;
            Conditions = conditions;
            DaemonEndpoints = daemonEndpoints;
            Images = images;
            NodeInfo = nodeInfo;
            Phase = phase;
            VolumesAttached = volumesAttached;
            VolumesInUse = volumesInUse;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of addresses reachable to the node. Queried from
        /// cloud provider, if available. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#addresses
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public IList<Iok8sapicorev1NodeAddress> Addresses { get; set; }

        /// <summary>
        /// Gets or sets allocatable represents the resources of a node that
        /// are available for scheduling. Defaults to Capacity.
        /// </summary>
        [JsonProperty(PropertyName = "allocatable")]
        public IDictionary<string, string> Allocatable { get; set; }

        /// <summary>
        /// Gets or sets capacity represents the total resources of a node.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public IDictionary<string, string> Capacity { get; set; }

        /// <summary>
        /// Gets or sets conditions is an array of current observed node
        /// conditions. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#condition
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<Iok8sapicorev1NodeCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets endpoints of daemons running on the Node.
        /// </summary>
        [JsonProperty(PropertyName = "daemonEndpoints")]
        public Iok8sapicorev1NodeDaemonEndpoints DaemonEndpoints { get; set; }

        /// <summary>
        /// Gets or sets list of container images on this node
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<Iok8sapicorev1ContainerImage> Images { get; set; }

        /// <summary>
        /// Gets or sets set of ids/uuids to uniquely identify the node. More
        /// info: https://kubernetes.io/docs/concepts/nodes/node/#info
        /// </summary>
        [JsonProperty(PropertyName = "nodeInfo")]
        public Iok8sapicorev1NodeSystemInfo NodeInfo { get; set; }

        /// <summary>
        /// Gets or sets nodePhase is the recently observed lifecycle phase of
        /// the node. More info:
        /// https://kubernetes.io/docs/concepts/nodes/node/#phase The field is
        /// never populated, and now is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        public string Phase { get; set; }

        /// <summary>
        /// Gets or sets list of volumes that are attached to the node.
        /// </summary>
        [JsonProperty(PropertyName = "volumesAttached")]
        public IList<Iok8sapicorev1AttachedVolume> VolumesAttached { get; set; }

        /// <summary>
        /// Gets or sets list of attachable volumes in use (mounted) by the
        /// node.
        /// </summary>
        [JsonProperty(PropertyName = "volumesInUse")]
        public IList<string> VolumesInUse { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Addresses != null)
            {
                foreach (var element in Addresses)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Conditions != null)
            {
                foreach (var element1 in Conditions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (DaemonEndpoints != null)
            {
                DaemonEndpoints.Validate();
            }
            if (Images != null)
            {
                foreach (var element2 in Images)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (NodeInfo != null)
            {
                NodeInfo.Validate();
            }
            if (VolumesAttached != null)
            {
                foreach (var element3 in VolumesAttached)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
