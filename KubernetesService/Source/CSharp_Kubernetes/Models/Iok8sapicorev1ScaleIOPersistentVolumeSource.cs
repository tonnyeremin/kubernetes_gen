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
    /// ScaleIOPersistentVolumeSource represents a persistent ScaleIO volume
    /// </summary>
    public partial class Iok8sapicorev1ScaleIOPersistentVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ScaleIOPersistentVolumeSource class.
        /// </summary>
        public Iok8sapicorev1ScaleIOPersistentVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ScaleIOPersistentVolumeSource class.
        /// </summary>
        /// <param name="gateway">The host address of the ScaleIO API
        /// Gateway.</param>
        /// <param name="secretRef">SecretRef references to the secret for
        /// ScaleIO user and other sensitive information. If this is not
        /// provided, Login operation will fail.</param>
        /// <param name="system">The name of the storage system as configured
        /// in ScaleIO.</param>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Ex. "ext4", "xfs",
        /// "ntfs". Implicitly inferred to be "ext4" if unspecified.</param>
        /// <param name="protectionDomain">The name of the ScaleIO Protection
        /// Domain for the configured storage.</param>
        /// <param name="readOnlyProperty">Defaults to false (read/write).
        /// ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.</param>
        /// <param name="sslEnabled">Flag to enable/disable SSL communication
        /// with Gateway, default false</param>
        /// <param name="storageMode">Indicates whether the storage for a
        /// volume should be ThickProvisioned or ThinProvisioned.</param>
        /// <param name="storagePool">The ScaleIO Storage Pool associated with
        /// the protection domain.</param>
        /// <param name="volumeName">The name of a volume already created in
        /// the ScaleIO system that is associated with this volume
        /// source.</param>
        public Iok8sapicorev1ScaleIOPersistentVolumeSource(string gateway, Iok8sapicorev1SecretReference secretRef, string system, string fsType = default(string), string protectionDomain = default(string), bool? readOnlyProperty = default(bool?), bool? sslEnabled = default(bool?), string storageMode = default(string), string storagePool = default(string), string volumeName = default(string))
        {
            FsType = fsType;
            Gateway = gateway;
            ProtectionDomain = protectionDomain;
            ReadOnlyProperty = readOnlyProperty;
            SecretRef = secretRef;
            SslEnabled = sslEnabled;
            StorageMode = storageMode;
            StoragePool = storagePool;
            System = system;
            VolumeName = volumeName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        /// Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets the host address of the ScaleIO API Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// Gets or sets the name of the ScaleIO Protection Domain for the
        /// configured storage.
        /// </summary>
        [JsonProperty(PropertyName = "protectionDomain")]
        public string ProtectionDomain { get; set; }

        /// <summary>
        /// Gets or sets defaults to false (read/write). ReadOnly here will
        /// force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets secretRef references to the secret for ScaleIO user
        /// and other sensitive information. If this is not provided, Login
        /// operation will fail.
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public Iok8sapicorev1SecretReference SecretRef { get; set; }

        /// <summary>
        /// Gets or sets flag to enable/disable SSL communication with Gateway,
        /// default false
        /// </summary>
        [JsonProperty(PropertyName = "sslEnabled")]
        public bool? SslEnabled { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the storage for a volume should be
        /// ThickProvisioned or ThinProvisioned.
        /// </summary>
        [JsonProperty(PropertyName = "storageMode")]
        public string StorageMode { get; set; }

        /// <summary>
        /// Gets or sets the ScaleIO Storage Pool associated with the
        /// protection domain.
        /// </summary>
        [JsonProperty(PropertyName = "storagePool")]
        public string StoragePool { get; set; }

        /// <summary>
        /// Gets or sets the name of the storage system as configured in
        /// ScaleIO.
        /// </summary>
        [JsonProperty(PropertyName = "system")]
        public string System { get; set; }

        /// <summary>
        /// Gets or sets the name of a volume already created in the ScaleIO
        /// system that is associated with this volume source.
        /// </summary>
        [JsonProperty(PropertyName = "volumeName")]
        public string VolumeName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Gateway == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Gateway");
            }
            if (SecretRef == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecretRef");
            }
            if (System == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "System");
            }
        }
    }
}