// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KubernetesService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// DEPRECATED. DeploymentRollback stores the information required to
    /// rollback a deployment.
    /// </summary>
    public partial class Iok8sapiextensionsv1beta1DeploymentRollback
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1DeploymentRollback class.
        /// </summary>
        public Iok8sapiextensionsv1beta1DeploymentRollback()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1DeploymentRollback class.
        /// </summary>
        /// <param name="name">Required: This must match the Name of a
        /// deployment.</param>
        /// <param name="rollbackTo">The config of this deployment
        /// rollback.</param>
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
        /// <param name="updatedAnnotations">The annotations to be updated to a
        /// deployment</param>
        public Iok8sapiextensionsv1beta1DeploymentRollback(string name, Iok8sapiextensionsv1beta1RollbackConfig rollbackTo, string apiVersion = default(string), string kind = default(string), IDictionary<string, string> updatedAnnotations = default(IDictionary<string, string>))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
            RollbackTo = rollbackTo;
            UpdatedAnnotations = updatedAnnotations;
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
        /// Gets or sets required: This must match the Name of a deployment.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the config of this deployment rollback.
        /// </summary>
        [JsonProperty(PropertyName = "rollbackTo")]
        public Iok8sapiextensionsv1beta1RollbackConfig RollbackTo { get; set; }

        /// <summary>
        /// Gets or sets the annotations to be updated to a deployment
        /// </summary>
        [JsonProperty(PropertyName = "updatedAnnotations")]
        public IDictionary<string, string> UpdatedAnnotations { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (RollbackTo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RollbackTo");
            }
        }
    }
}
