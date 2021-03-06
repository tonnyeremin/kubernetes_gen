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
    /// Volume represents a named volume in a pod that may be accessed by any
    /// container in the pod.
    /// </summary>
    public partial class Iok8sapicorev1Volume
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1Volume class.
        /// </summary>
        public Iok8sapicorev1Volume()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1Volume class.
        /// </summary>
        /// <param name="name">Volume's name. Must be a DNS_LABEL and unique
        /// within the pod. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</param>
        /// <param name="awsElasticBlockStore">AWSElasticBlockStore represents
        /// an AWS Disk resource that is attached to a kubelet's host machine
        /// and then exposed to the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore</param>
        /// <param name="azureDisk">AzureDisk represents an Azure Data Disk
        /// mount on the host and bind mount to the pod.</param>
        /// <param name="azureFile">AzureFile represents an Azure File Service
        /// mount on the host and bind mount to the pod.</param>
        /// <param name="cephfs">CephFS represents a Ceph FS mount on the host
        /// that shares a pod's lifetime</param>
        /// <param name="cinder">Cinder represents a cinder volume attached and
        /// mounted on kubelets host machine More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md</param>
        /// <param name="configMap">ConfigMap represents a configMap that
        /// should populate this volume</param>
        /// <param name="downwardAPI">DownwardAPI represents downward API about
        /// the pod that should populate this volume</param>
        /// <param name="emptyDir">EmptyDir represents a temporary directory
        /// that shares a pod's lifetime. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#emptydir</param>
        /// <param name="fc">FC represents a Fibre Channel resource that is
        /// attached to a kubelet's host machine and then exposed to the
        /// pod.</param>
        /// <param name="flexVolume">FlexVolume represents a generic volume
        /// resource that is provisioned/attached using an exec based plugin.
        /// This is an alpha feature and may change in future.</param>
        /// <param name="flocker">Flocker represents a Flocker volume attached
        /// to a kubelet's host machine. This depends on the Flocker control
        /// service being running</param>
        /// <param name="gcePersistentDisk">GCEPersistentDisk represents a GCE
        /// Disk resource that is attached to a kubelet's host machine and then
        /// exposed to the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk</param>
        /// <param name="gitRepo">GitRepo represents a git repository at a
        /// particular revision.</param>
        /// <param name="glusterfs">Glusterfs represents a Glusterfs mount on
        /// the host that shares a pod's lifetime. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md</param>
        /// <param name="hostPath">HostPath represents a pre-existing file or
        /// directory on the host machine that is directly exposed to the
        /// container. This is generally used for system agents or other
        /// privileged things that are allowed to see the host machine. Most
        /// containers will NOT need this. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath</param>
        /// <param name="iscsi">ISCSI represents an ISCSI Disk resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md</param>
        /// <param name="nfs">NFS represents an NFS mount on the host that
        /// shares a pod's lifetime More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#nfs</param>
        /// <param
        /// name="persistentVolumeClaim">PersistentVolumeClaimVolumeSource
        /// represents a reference to a PersistentVolumeClaim in the same
        /// namespace. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims</param>
        /// <param name="photonPersistentDisk">PhotonPersistentDisk represents
        /// a PhotonController persistent disk attached and mounted on kubelets
        /// host machine</param>
        /// <param name="portworxVolume">PortworxVolume represents a portworx
        /// volume attached and mounted on kubelets host machine</param>
        /// <param name="projected">Items for all in one resources secrets,
        /// configmaps, and downward API</param>
        /// <param name="quobyte">Quobyte represents a Quobyte mount on the
        /// host that shares a pod's lifetime</param>
        /// <param name="rbd">RBD represents a Rados Block Device mount on the
        /// host that shares a pod's lifetime. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md</param>
        /// <param name="scaleIO">ScaleIO represents a ScaleIO persistent
        /// volume attached and mounted on Kubernetes nodes.</param>
        /// <param name="secret">Secret represents a secret that should
        /// populate this volume. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#secret</param>
        /// <param name="storageos">StorageOS represents a StorageOS volume
        /// attached and mounted on Kubernetes nodes.</param>
        /// <param name="vsphereVolume">VsphereVolume represents a vSphere
        /// volume attached and mounted on kubelets host machine</param>
        public Iok8sapicorev1Volume(string name, Iok8sapicorev1AWSElasticBlockStoreVolumeSource awsElasticBlockStore = default(Iok8sapicorev1AWSElasticBlockStoreVolumeSource), Iok8sapicorev1AzureDiskVolumeSource azureDisk = default(Iok8sapicorev1AzureDiskVolumeSource), Iok8sapicorev1AzureFileVolumeSource azureFile = default(Iok8sapicorev1AzureFileVolumeSource), Iok8sapicorev1CephFSVolumeSource cephfs = default(Iok8sapicorev1CephFSVolumeSource), Iok8sapicorev1CinderVolumeSource cinder = default(Iok8sapicorev1CinderVolumeSource), Iok8sapicorev1ConfigMapVolumeSource configMap = default(Iok8sapicorev1ConfigMapVolumeSource), Iok8sapicorev1DownwardAPIVolumeSource downwardAPI = default(Iok8sapicorev1DownwardAPIVolumeSource), Iok8sapicorev1EmptyDirVolumeSource emptyDir = default(Iok8sapicorev1EmptyDirVolumeSource), Iok8sapicorev1FCVolumeSource fc = default(Iok8sapicorev1FCVolumeSource), Iok8sapicorev1FlexVolumeSource flexVolume = default(Iok8sapicorev1FlexVolumeSource), Iok8sapicorev1FlockerVolumeSource flocker = default(Iok8sapicorev1FlockerVolumeSource), Iok8sapicorev1GCEPersistentDiskVolumeSource gcePersistentDisk = default(Iok8sapicorev1GCEPersistentDiskVolumeSource), Iok8sapicorev1GitRepoVolumeSource gitRepo = default(Iok8sapicorev1GitRepoVolumeSource), Iok8sapicorev1GlusterfsVolumeSource glusterfs = default(Iok8sapicorev1GlusterfsVolumeSource), Iok8sapicorev1HostPathVolumeSource hostPath = default(Iok8sapicorev1HostPathVolumeSource), Iok8sapicorev1ISCSIVolumeSource iscsi = default(Iok8sapicorev1ISCSIVolumeSource), Iok8sapicorev1NFSVolumeSource nfs = default(Iok8sapicorev1NFSVolumeSource), Iok8sapicorev1PersistentVolumeClaimVolumeSource persistentVolumeClaim = default(Iok8sapicorev1PersistentVolumeClaimVolumeSource), Iok8sapicorev1PhotonPersistentDiskVolumeSource photonPersistentDisk = default(Iok8sapicorev1PhotonPersistentDiskVolumeSource), Iok8sapicorev1PortworxVolumeSource portworxVolume = default(Iok8sapicorev1PortworxVolumeSource), Iok8sapicorev1ProjectedVolumeSource projected = default(Iok8sapicorev1ProjectedVolumeSource), Iok8sapicorev1QuobyteVolumeSource quobyte = default(Iok8sapicorev1QuobyteVolumeSource), Iok8sapicorev1RBDVolumeSource rbd = default(Iok8sapicorev1RBDVolumeSource), Iok8sapicorev1ScaleIOVolumeSource scaleIO = default(Iok8sapicorev1ScaleIOVolumeSource), Iok8sapicorev1SecretVolumeSource secret = default(Iok8sapicorev1SecretVolumeSource), Iok8sapicorev1StorageOSVolumeSource storageos = default(Iok8sapicorev1StorageOSVolumeSource), Iok8sapicorev1VsphereVirtualDiskVolumeSource vsphereVolume = default(Iok8sapicorev1VsphereVirtualDiskVolumeSource))
        {
            AwsElasticBlockStore = awsElasticBlockStore;
            AzureDisk = azureDisk;
            AzureFile = azureFile;
            Cephfs = cephfs;
            Cinder = cinder;
            ConfigMap = configMap;
            DownwardAPI = downwardAPI;
            EmptyDir = emptyDir;
            Fc = fc;
            FlexVolume = flexVolume;
            Flocker = flocker;
            GcePersistentDisk = gcePersistentDisk;
            GitRepo = gitRepo;
            Glusterfs = glusterfs;
            HostPath = hostPath;
            Iscsi = iscsi;
            Name = name;
            Nfs = nfs;
            PersistentVolumeClaim = persistentVolumeClaim;
            PhotonPersistentDisk = photonPersistentDisk;
            PortworxVolume = portworxVolume;
            Projected = projected;
            Quobyte = quobyte;
            Rbd = rbd;
            ScaleIO = scaleIO;
            Secret = secret;
            Storageos = storageos;
            VsphereVolume = vsphereVolume;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aWSElasticBlockStore represents an AWS Disk resource
        /// that is attached to a kubelet's host machine and then exposed to
        /// the pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "awsElasticBlockStore")]
        public Iok8sapicorev1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>
        /// Gets or sets azureDisk represents an Azure Data Disk mount on the
        /// host and bind mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureDisk")]
        public Iok8sapicorev1AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>
        /// Gets or sets azureFile represents an Azure File Service mount on
        /// the host and bind mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureFile")]
        public Iok8sapicorev1AzureFileVolumeSource AzureFile { get; set; }

        /// <summary>
        /// Gets or sets cephFS represents a Ceph FS mount on the host that
        /// shares a pod's lifetime
        /// </summary>
        [JsonProperty(PropertyName = "cephfs")]
        public Iok8sapicorev1CephFSVolumeSource Cephfs { get; set; }

        /// <summary>
        /// Gets or sets cinder represents a cinder volume attached and mounted
        /// on kubelets host machine More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "cinder")]
        public Iok8sapicorev1CinderVolumeSource Cinder { get; set; }

        /// <summary>
        /// Gets or sets configMap represents a configMap that should populate
        /// this volume
        /// </summary>
        [JsonProperty(PropertyName = "configMap")]
        public Iok8sapicorev1ConfigMapVolumeSource ConfigMap { get; set; }

        /// <summary>
        /// Gets or sets downwardAPI represents downward API about the pod that
        /// should populate this volume
        /// </summary>
        [JsonProperty(PropertyName = "downwardAPI")]
        public Iok8sapicorev1DownwardAPIVolumeSource DownwardAPI { get; set; }

        /// <summary>
        /// Gets or sets emptyDir represents a temporary directory that shares
        /// a pod's lifetime. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        [JsonProperty(PropertyName = "emptyDir")]
        public Iok8sapicorev1EmptyDirVolumeSource EmptyDir { get; set; }

        /// <summary>
        /// Gets or sets FC represents a Fibre Channel resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "fc")]
        public Iok8sapicorev1FCVolumeSource Fc { get; set; }

        /// <summary>
        /// Gets or sets flexVolume represents a generic volume resource that
        /// is provisioned/attached using an exec based plugin. This is an
        /// alpha feature and may change in future.
        /// </summary>
        [JsonProperty(PropertyName = "flexVolume")]
        public Iok8sapicorev1FlexVolumeSource FlexVolume { get; set; }

        /// <summary>
        /// Gets or sets flocker represents a Flocker volume attached to a
        /// kubelet's host machine. This depends on the Flocker control service
        /// being running
        /// </summary>
        [JsonProperty(PropertyName = "flocker")]
        public Iok8sapicorev1FlockerVolumeSource Flocker { get; set; }

        /// <summary>
        /// Gets or sets gCEPersistentDisk represents a GCE Disk resource that
        /// is attached to a kubelet's host machine and then exposed to the
        /// pod. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "gcePersistentDisk")]
        public Iok8sapicorev1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>
        /// Gets or sets gitRepo represents a git repository at a particular
        /// revision.
        /// </summary>
        [JsonProperty(PropertyName = "gitRepo")]
        public Iok8sapicorev1GitRepoVolumeSource GitRepo { get; set; }

        /// <summary>
        /// Gets or sets glusterfs represents a Glusterfs mount on the host
        /// that shares a pod's lifetime. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
        /// </summary>
        [JsonProperty(PropertyName = "glusterfs")]
        public Iok8sapicorev1GlusterfsVolumeSource Glusterfs { get; set; }

        /// <summary>
        /// Gets or sets hostPath represents a pre-existing file or directory
        /// on the host machine that is directly exposed to the container. This
        /// is generally used for system agents or other privileged things that
        /// are allowed to see the host machine. Most containers will NOT need
        /// this. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "hostPath")]
        public Iok8sapicorev1HostPathVolumeSource HostPath { get; set; }

        /// <summary>
        /// Gets or sets ISCSI represents an ISCSI Disk resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/iscsi/README.md
        /// </summary>
        [JsonProperty(PropertyName = "iscsi")]
        public Iok8sapicorev1ISCSIVolumeSource Iscsi { get; set; }

        /// <summary>
        /// Gets or sets volume's name. Must be a DNS_LABEL and unique within
        /// the pod. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets NFS represents an NFS mount on the host that shares a
        /// pod's lifetime More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [JsonProperty(PropertyName = "nfs")]
        public Iok8sapicorev1NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// Gets or sets persistentVolumeClaimVolumeSource represents a
        /// reference to a PersistentVolumeClaim in the same namespace. More
        /// info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [JsonProperty(PropertyName = "persistentVolumeClaim")]
        public Iok8sapicorev1PersistentVolumeClaimVolumeSource PersistentVolumeClaim { get; set; }

        /// <summary>
        /// Gets or sets photonPersistentDisk represents a PhotonController
        /// persistent disk attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "photonPersistentDisk")]
        public Iok8sapicorev1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>
        /// Gets or sets portworxVolume represents a portworx volume attached
        /// and mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "portworxVolume")]
        public Iok8sapicorev1PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>
        /// Gets or sets items for all in one resources secrets, configmaps,
        /// and downward API
        /// </summary>
        [JsonProperty(PropertyName = "projected")]
        public Iok8sapicorev1ProjectedVolumeSource Projected { get; set; }

        /// <summary>
        /// Gets or sets quobyte represents a Quobyte mount on the host that
        /// shares a pod's lifetime
        /// </summary>
        [JsonProperty(PropertyName = "quobyte")]
        public Iok8sapicorev1QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>
        /// Gets or sets RBD represents a Rados Block Device mount on the host
        /// that shares a pod's lifetime. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "rbd")]
        public Iok8sapicorev1RBDVolumeSource Rbd { get; set; }

        /// <summary>
        /// Gets or sets scaleIO represents a ScaleIO persistent volume
        /// attached and mounted on Kubernetes nodes.
        /// </summary>
        [JsonProperty(PropertyName = "scaleIO")]
        public Iok8sapicorev1ScaleIOVolumeSource ScaleIO { get; set; }

        /// <summary>
        /// Gets or sets secret represents a secret that should populate this
        /// volume. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public Iok8sapicorev1SecretVolumeSource Secret { get; set; }

        /// <summary>
        /// Gets or sets storageOS represents a StorageOS volume attached and
        /// mounted on Kubernetes nodes.
        /// </summary>
        [JsonProperty(PropertyName = "storageos")]
        public Iok8sapicorev1StorageOSVolumeSource Storageos { get; set; }

        /// <summary>
        /// Gets or sets vsphereVolume represents a vSphere volume attached and
        /// mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "vsphereVolume")]
        public Iok8sapicorev1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

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
            if (AwsElasticBlockStore != null)
            {
                AwsElasticBlockStore.Validate();
            }
            if (AzureDisk != null)
            {
                AzureDisk.Validate();
            }
            if (AzureFile != null)
            {
                AzureFile.Validate();
            }
            if (Cephfs != null)
            {
                Cephfs.Validate();
            }
            if (Cinder != null)
            {
                Cinder.Validate();
            }
            if (FlexVolume != null)
            {
                FlexVolume.Validate();
            }
            if (GcePersistentDisk != null)
            {
                GcePersistentDisk.Validate();
            }
            if (GitRepo != null)
            {
                GitRepo.Validate();
            }
            if (Glusterfs != null)
            {
                Glusterfs.Validate();
            }
            if (HostPath != null)
            {
                HostPath.Validate();
            }
            if (Iscsi != null)
            {
                Iscsi.Validate();
            }
            if (Nfs != null)
            {
                Nfs.Validate();
            }
            if (PersistentVolumeClaim != null)
            {
                PersistentVolumeClaim.Validate();
            }
            if (PhotonPersistentDisk != null)
            {
                PhotonPersistentDisk.Validate();
            }
            if (PortworxVolume != null)
            {
                PortworxVolume.Validate();
            }
            if (Projected != null)
            {
                Projected.Validate();
            }
            if (Quobyte != null)
            {
                Quobyte.Validate();
            }
            if (Rbd != null)
            {
                Rbd.Validate();
            }
            if (ScaleIO != null)
            {
                ScaleIO.Validate();
            }
            if (VsphereVolume != null)
            {
                VsphereVolume.Validate();
            }
        }
    }
}
