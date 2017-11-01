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
    /// SubjectAccessReviewStatus
    /// </summary>
    public partial class Iok8sapiauthorizationv1SubjectAccessReviewStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SubjectAccessReviewStatus class.
        /// </summary>
        public Iok8sapiauthorizationv1SubjectAccessReviewStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SubjectAccessReviewStatus class.
        /// </summary>
        /// <param name="allowed">Allowed is required.  True if the action
        /// would be allowed, false otherwise.</param>
        /// <param name="evaluationError">EvaluationError is an indication that
        /// some error occurred during the authorization check. It is entirely
        /// possible to get an error and be able to continue determine
        /// authorization status in spite of it. For instance, RBAC can be
        /// missing a role, but enough roles are still present and bound to
        /// reason about the request.</param>
        /// <param name="reason">Reason is optional.  It indicates why a
        /// request was allowed or denied.</param>
        public Iok8sapiauthorizationv1SubjectAccessReviewStatus(bool allowed, string evaluationError = default(string), string reason = default(string))
        {
            Allowed = allowed;
            EvaluationError = evaluationError;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowed is required.  True if the action would be
        /// allowed, false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "allowed")]
        public bool Allowed { get; set; }

        /// <summary>
        /// Gets or sets evaluationError is an indication that some error
        /// occurred during the authorization check. It is entirely possible to
        /// get an error and be able to continue determine authorization status
        /// in spite of it. For instance, RBAC can be missing a role, but
        /// enough roles are still present and bound to reason about the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "evaluationError")]
        public string EvaluationError { get; set; }

        /// <summary>
        /// Gets or sets reason is optional.  It indicates why a request was
        /// allowed or denied.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
