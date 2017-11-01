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
    /// SubjectAccessReview checks whether or not a user or group can perform
    /// an action.
    /// </summary>
    public partial class Iok8sapiauthorizationv1SubjectAccessReview
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SubjectAccessReview class.
        /// </summary>
        public Iok8sapiauthorizationv1SubjectAccessReview()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SubjectAccessReview class.
        /// </summary>
        /// <param name="spec">Spec holds information about the request being
        /// evaluated</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds</param>
        /// <param name="status">Status is filled in by the server and
        /// indicates whether the request is allowed or not</param>
        public Iok8sapiauthorizationv1SubjectAccessReview(Iok8sapiauthorizationv1SubjectAccessReviewSpec spec, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8sapiauthorizationv1SubjectAccessReviewStatus status = default(Iok8sapiauthorizationv1SubjectAccessReviewStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
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
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets spec holds information about the request being
        /// evaluated
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8sapiauthorizationv1SubjectAccessReviewSpec Spec { get; set; }

        /// <summary>
        /// Gets or sets status is filled in by the server and indicates
        /// whether the request is allowed or not
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8sapiauthorizationv1SubjectAccessReviewStatus Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Spec == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Spec");
            }
            if (Metadata != null)
            {
                Metadata.Validate();
            }
            if (Status != null)
            {
                Status.Validate();
            }
        }
    }
}
