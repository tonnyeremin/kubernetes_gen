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
    /// A label selector requirement is a selector that contains values, a key,
    /// and an operator that relates the key and values.
    /// </summary>
    public partial class Iok8sapimachinerypkgapismetav1LabelSelectorRequirement
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1LabelSelectorRequirement class.
        /// </summary>
        public Iok8sapimachinerypkgapismetav1LabelSelectorRequirement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapimachinerypkgapismetav1LabelSelectorRequirement class.
        /// </summary>
        /// <param name="key">key is the label key that the selector applies
        /// to.</param>
        /// <param name="operatorProperty">operator represents a key's
        /// relationship to a set of values. Valid operators are In, NotIn,
        /// Exists and DoesNotExist.</param>
        /// <param name="values">values is an array of string values. If the
        /// operator is In or NotIn, the values array must be non-empty. If the
        /// operator is Exists or DoesNotExist, the values array must be empty.
        /// This array is replaced during a strategic merge patch.</param>
        public Iok8sapimachinerypkgapismetav1LabelSelectorRequirement(string key, string operatorProperty, IList<string> values = default(IList<string>))
        {
            Key = key;
            OperatorProperty = operatorProperty;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key is the label key that the selector applies to.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets operator represents a key's relationship to a set of
        /// values. Valid operators are In, NotIn, Exists and DoesNotExist.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public string OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets values is an array of string values. If the operator
        /// is In or NotIn, the values array must be non-empty. If the operator
        /// is Exists or DoesNotExist, the values array must be empty. This
        /// array is replaced during a strategic merge patch.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Key == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Key");
            }
            if (OperatorProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OperatorProperty");
            }
        }
    }
}
