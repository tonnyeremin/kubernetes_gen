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
    /// Represents a host path mapped into a pod. Host path volumes do not
    /// support ownership management or SELinux relabeling.
    /// </summary>
    public partial class Iok8sapicorev1HostPathVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1HostPathVolumeSource class.
        /// </summary>
        public Iok8sapicorev1HostPathVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1HostPathVolumeSource class.
        /// </summary>
        /// <param name="path">Path of the directory on the host. If the path
        /// is a symlink, it will follow the link to the real path. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath</param>
        /// <param name="type">Type for HostPath Volume Defaults to "" More
        /// info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath</param>
        public Iok8sapicorev1HostPathVolumeSource(string path, string type = default(string))
        {
            Path = path;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets path of the directory on the host. If the path is a
        /// symlink, it will follow the link to the real path. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets type for HostPath Volume Defaults to "" More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}
