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
    /// Pod Security Policy Spec defines the policy enforced.
    /// </summary>
    public partial class Iok8sapiextensionsv1beta1PodSecurityPolicySpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1PodSecurityPolicySpec class.
        /// </summary>
        public Iok8sapiextensionsv1beta1PodSecurityPolicySpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1PodSecurityPolicySpec class.
        /// </summary>
        /// <param name="fsGroup">FSGroup is the strategy that will dictate
        /// what fs group is used by the SecurityContext.</param>
        /// <param name="runAsUser">runAsUser is the strategy that will dictate
        /// the allowable RunAsUser values that may be set.</param>
        /// <param name="seLinux">seLinux is the strategy that will dictate the
        /// allowable labels that may be set.</param>
        /// <param name="supplementalGroups">SupplementalGroups is the strategy
        /// that will dictate what supplemental groups are used by the
        /// SecurityContext.</param>
        /// <param name="allowPrivilegeEscalation">AllowPrivilegeEscalation
        /// determines if a pod can request to allow privilege escalation. If
        /// unspecified, defaults to true.</param>
        /// <param name="allowedCapabilities">AllowedCapabilities is a list of
        /// capabilities that can be requested to add to the container.
        /// Capabilities in this field may be added at the pod author's
        /// discretion. You must not list a capability in both
        /// AllowedCapabilities and RequiredDropCapabilities.</param>
        /// <param name="allowedHostPaths">is a white list of allowed host
        /// paths. Empty indicates that all host paths may be used.</param>
        /// <param name="defaultAddCapabilities">DefaultAddCapabilities is the
        /// default set of capabilities that will be added to the container
        /// unless the pod spec specifically drops the capability.  You may not
        /// list a capabiility in both DefaultAddCapabilities and
        /// RequiredDropCapabilities.</param>
        /// <param
        /// name="defaultAllowPrivilegeEscalation">DefaultAllowPrivilegeEscalation
        /// controls the default setting for whether a process can gain more
        /// privileges than its parent process.</param>
        /// <param name="hostIPC">hostIPC determines if the policy allows the
        /// use of HostIPC in the pod spec.</param>
        /// <param name="hostNetwork">hostNetwork determines if the policy
        /// allows the use of HostNetwork in the pod spec.</param>
        /// <param name="hostPID">hostPID determines if the policy allows the
        /// use of HostPID in the pod spec.</param>
        /// <param name="hostPorts">hostPorts determines which host port ranges
        /// are allowed to be exposed.</param>
        /// <param name="privileged">privileged determines if a pod can request
        /// to be run as privileged.</param>
        /// <param name="readOnlyRootFilesystem">ReadOnlyRootFilesystem when
        /// set to true will force containers to run with a read only root file
        /// system.  If the container specifically requests to run with a
        /// non-read only root file system the PSP should deny the pod. If set
        /// to false the container may run with a read only root file system if
        /// it wishes but it will not be forced to.</param>
        /// <param name="requiredDropCapabilities">RequiredDropCapabilities are
        /// the capabilities that will be dropped from the container.  These
        /// are required to be dropped and cannot be added.</param>
        /// <param name="volumes">volumes is a white list of allowed volume
        /// plugins.  Empty indicates that all plugins may be used.</param>
        public Iok8sapiextensionsv1beta1PodSecurityPolicySpec(Iok8sapiextensionsv1beta1FSGroupStrategyOptions fsGroup, Iok8sapiextensionsv1beta1RunAsUserStrategyOptions runAsUser, Iok8sapiextensionsv1beta1SELinuxStrategyOptions seLinux, Iok8sapiextensionsv1beta1SupplementalGroupsStrategyOptions supplementalGroups, bool? allowPrivilegeEscalation = default(bool?), IList<string> allowedCapabilities = default(IList<string>), IList<Iok8sapiextensionsv1beta1AllowedHostPath> allowedHostPaths = default(IList<Iok8sapiextensionsv1beta1AllowedHostPath>), IList<string> defaultAddCapabilities = default(IList<string>), bool? defaultAllowPrivilegeEscalation = default(bool?), bool? hostIPC = default(bool?), bool? hostNetwork = default(bool?), bool? hostPID = default(bool?), IList<Iok8sapiextensionsv1beta1HostPortRange> hostPorts = default(IList<Iok8sapiextensionsv1beta1HostPortRange>), bool? privileged = default(bool?), bool? readOnlyRootFilesystem = default(bool?), IList<string> requiredDropCapabilities = default(IList<string>), IList<string> volumes = default(IList<string>))
        {
            AllowPrivilegeEscalation = allowPrivilegeEscalation;
            AllowedCapabilities = allowedCapabilities;
            AllowedHostPaths = allowedHostPaths;
            DefaultAddCapabilities = defaultAddCapabilities;
            DefaultAllowPrivilegeEscalation = defaultAllowPrivilegeEscalation;
            FsGroup = fsGroup;
            HostIPC = hostIPC;
            HostNetwork = hostNetwork;
            HostPID = hostPID;
            HostPorts = hostPorts;
            Privileged = privileged;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RequiredDropCapabilities = requiredDropCapabilities;
            RunAsUser = runAsUser;
            SeLinux = seLinux;
            SupplementalGroups = supplementalGroups;
            Volumes = volumes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowPrivilegeEscalation determines if a pod can
        /// request to allow privilege escalation. If unspecified, defaults to
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "allowPrivilegeEscalation")]
        public bool? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Gets or sets allowedCapabilities is a list of capabilities that can
        /// be requested to add to the container. Capabilities in this field
        /// may be added at the pod author's discretion. You must not list a
        /// capability in both AllowedCapabilities and
        /// RequiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "allowedCapabilities")]
        public IList<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// Gets or sets is a white list of allowed host paths. Empty indicates
        /// that all host paths may be used.
        /// </summary>
        [JsonProperty(PropertyName = "allowedHostPaths")]
        public IList<Iok8sapiextensionsv1beta1AllowedHostPath> AllowedHostPaths { get; set; }

        /// <summary>
        /// Gets or sets defaultAddCapabilities is the default set of
        /// capabilities that will be added to the container unless the pod
        /// spec specifically drops the capability.  You may not list a
        /// capabiility in both DefaultAddCapabilities and
        /// RequiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAddCapabilities")]
        public IList<string> DefaultAddCapabilities { get; set; }

        /// <summary>
        /// Gets or sets defaultAllowPrivilegeEscalation controls the default
        /// setting for whether a process can gain more privileges than its
        /// parent process.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAllowPrivilegeEscalation")]
        public bool? DefaultAllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Gets or sets fSGroup is the strategy that will dictate what fs
        /// group is used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "fsGroup")]
        public Iok8sapiextensionsv1beta1FSGroupStrategyOptions FsGroup { get; set; }

        /// <summary>
        /// Gets or sets hostIPC determines if the policy allows the use of
        /// HostIPC in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostIPC")]
        public bool? HostIPC { get; set; }

        /// <summary>
        /// Gets or sets hostNetwork determines if the policy allows the use of
        /// HostNetwork in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostNetwork")]
        public bool? HostNetwork { get; set; }

        /// <summary>
        /// Gets or sets hostPID determines if the policy allows the use of
        /// HostPID in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "hostPID")]
        public bool? HostPID { get; set; }

        /// <summary>
        /// Gets or sets hostPorts determines which host port ranges are
        /// allowed to be exposed.
        /// </summary>
        [JsonProperty(PropertyName = "hostPorts")]
        public IList<Iok8sapiextensionsv1beta1HostPortRange> HostPorts { get; set; }

        /// <summary>
        /// Gets or sets privileged determines if a pod can request to be run
        /// as privileged.
        /// </summary>
        [JsonProperty(PropertyName = "privileged")]
        public bool? Privileged { get; set; }

        /// <summary>
        /// Gets or sets readOnlyRootFilesystem when set to true will force
        /// containers to run with a read only root file system.  If the
        /// container specifically requests to run with a non-read only root
        /// file system the PSP should deny the pod. If set to false the
        /// container may run with a read only root file system if it wishes
        /// but it will not be forced to.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// Gets or sets requiredDropCapabilities are the capabilities that
        /// will be dropped from the container.  These are required to be
        /// dropped and cannot be added.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDropCapabilities")]
        public IList<string> RequiredDropCapabilities { get; set; }

        /// <summary>
        /// Gets or sets runAsUser is the strategy that will dictate the
        /// allowable RunAsUser values that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public Iok8sapiextensionsv1beta1RunAsUserStrategyOptions RunAsUser { get; set; }

        /// <summary>
        /// Gets or sets seLinux is the strategy that will dictate the
        /// allowable labels that may be set.
        /// </summary>
        [JsonProperty(PropertyName = "seLinux")]
        public Iok8sapiextensionsv1beta1SELinuxStrategyOptions SeLinux { get; set; }

        /// <summary>
        /// Gets or sets supplementalGroups is the strategy that will dictate
        /// what supplemental groups are used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "supplementalGroups")]
        public Iok8sapiextensionsv1beta1SupplementalGroupsStrategyOptions SupplementalGroups { get; set; }

        /// <summary>
        /// Gets or sets volumes is a white list of allowed volume plugins.
        /// Empty indicates that all plugins may be used.
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<string> Volumes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FsGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FsGroup");
            }
            if (RunAsUser == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RunAsUser");
            }
            if (SeLinux == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SeLinux");
            }
            if (SupplementalGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SupplementalGroups");
            }
            if (HostPorts != null)
            {
                foreach (var element in HostPorts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (RunAsUser != null)
            {
                RunAsUser.Validate();
            }
            if (SeLinux != null)
            {
                SeLinux.Validate();
            }
        }
    }
}
