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
    /// EnvVar represents an environment variable present in a Container.
    /// </summary>
    public partial class Iok8sapicorev1EnvVar
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1EnvVar class.
        /// </summary>
        public Iok8sapicorev1EnvVar()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1EnvVar class.
        /// </summary>
        /// <param name="name">Name of the environment variable. Must be a
        /// C_IDENTIFIER.</param>
        /// <param name="value">Variable references $(VAR_NAME) are expanded
        /// using the previous defined environment variables in the container
        /// and any service environment variables. If a variable cannot be
        /// resolved, the reference in the input string will be unchanged. The
        /// $(VAR_NAME) syntax can be escaped with a double $$, ie:
        /// $$(VAR_NAME). Escaped references will never be expanded, regardless
        /// of whether the variable exists or not. Defaults to "".</param>
        /// <param name="valueFrom">Source for the environment variable's
        /// value. Cannot be used if value is not empty.</param>
        public Iok8sapicorev1EnvVar(string name, string value = default(string), Iok8sapicorev1EnvVarSource valueFrom = default(Iok8sapicorev1EnvVarSource))
        {
            Name = name;
            Value = value;
            ValueFrom = valueFrom;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the environment variable. Must be a
        /// C_IDENTIFIER.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets variable references $(VAR_NAME) are expanded using the
        /// previous defined environment variables in the container and any
        /// service environment variables. If a variable cannot be resolved,
        /// the reference in the input string will be unchanged. The
        /// $(VAR_NAME) syntax can be escaped with a double $$, ie:
        /// $$(VAR_NAME). Escaped references will never be expanded, regardless
        /// of whether the variable exists or not. Defaults to "".
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets source for the environment variable's value. Cannot be
        /// used if value is not empty.
        /// </summary>
        [JsonProperty(PropertyName = "valueFrom")]
        public Iok8sapicorev1EnvVarSource ValueFrom { get; set; }

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
            if (ValueFrom != null)
            {
                ValueFrom.Validate();
            }
        }
    }
}
