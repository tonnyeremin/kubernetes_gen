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
    /// PriorityClass defines mapping from a priority class name to the
    /// priority integer value. The value can be any valid integer.
    /// </summary>
    public partial class Iok8sapischedulingv1alpha1PriorityClass
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapischedulingv1alpha1PriorityClass class.
        /// </summary>
        public Iok8sapischedulingv1alpha1PriorityClass()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapischedulingv1alpha1PriorityClass class.
        /// </summary>
        /// <param name="value">The value of this priority class. This is the
        /// actual priority that pods receive when they have the name of this
        /// class in their pod spec.</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="description">description is an arbitrary string that
        /// usually provides guidelines on when this priority class should be
        /// used.</param>
        /// <param name="globalDefault">globalDefault specifies whether this
        /// PriorityClass should be considered as the default priority for pods
        /// that do not have any priority class.</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</param>
        public Iok8sapischedulingv1alpha1PriorityClass(int value, string apiVersion = default(string), string description = default(string), bool? globalDefault = default(bool?), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Description = description;
            GlobalDefault = globalDefault;
            Kind = kind;
            Metadata = metadata;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets description is an arbitrary string that usually
        /// provides guidelines on when this priority class should be used.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets globalDefault specifies whether this PriorityClass
        /// should be considered as the default priority for pods that do not
        /// have any priority class.
        /// </summary>
        [JsonProperty(PropertyName = "globalDefault")]
        public bool? GlobalDefault { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets the value of this priority class. This is the actual
        /// priority that pods receive when they have the name of this class in
        /// their pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public int Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Metadata != null)
            {
                Metadata.Validate();
            }
        }
    }
}