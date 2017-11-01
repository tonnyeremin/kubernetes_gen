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
    /// NetworkPolicyPeer describes a peer to allow traffic from. Exactly one
    /// of its fields must be specified.
    /// </summary>
    public partial class Iok8sapinetworkingv1NetworkPolicyPeer
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapinetworkingv1NetworkPolicyPeer class.
        /// </summary>
        public Iok8sapinetworkingv1NetworkPolicyPeer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapinetworkingv1NetworkPolicyPeer class.
        /// </summary>
        /// <param name="ipBlock">IPBlock defines policy on a particular
        /// IPBlock</param>
        /// <param name="namespaceSelector">Selects Namespaces using cluster
        /// scoped-labels. This matches all pods in all namespaces selected by
        /// this label selector. This field follows standard label selector
        /// semantics. If present but empty, this selector selects all
        /// namespaces.</param>
        /// <param name="podSelector">This is a label selector which selects
        /// Pods in this namespace. This field follows standard label selector
        /// semantics. If present but empty, this selector selects all pods in
        /// this namespace.</param>
        public Iok8sapinetworkingv1NetworkPolicyPeer(Iok8sapinetworkingv1IPBlock ipBlock = default(Iok8sapinetworkingv1IPBlock), Iok8sapimachinerypkgapismetav1LabelSelector namespaceSelector = default(Iok8sapimachinerypkgapismetav1LabelSelector), Iok8sapimachinerypkgapismetav1LabelSelector podSelector = default(Iok8sapimachinerypkgapismetav1LabelSelector))
        {
            IpBlock = ipBlock;
            NamespaceSelector = namespaceSelector;
            PodSelector = podSelector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets iPBlock defines policy on a particular IPBlock
        /// </summary>
        [JsonProperty(PropertyName = "ipBlock")]
        public Iok8sapinetworkingv1IPBlock IpBlock { get; set; }

        /// <summary>
        /// Gets or sets selects Namespaces using cluster scoped-labels. This
        /// matches all pods in all namespaces selected by this label selector.
        /// This field follows standard label selector semantics. If present
        /// but empty, this selector selects all namespaces.
        /// </summary>
        [JsonProperty(PropertyName = "namespaceSelector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector NamespaceSelector { get; set; }

        /// <summary>
        /// Gets or sets this is a label selector which selects Pods in this
        /// namespace. This field follows standard label selector semantics. If
        /// present but empty, this selector selects all pods in this
        /// namespace.
        /// </summary>
        [JsonProperty(PropertyName = "podSelector")]
        public Iok8sapimachinerypkgapismetav1LabelSelector PodSelector { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IpBlock != null)
            {
                IpBlock.Validate();
            }
        }
    }
}
