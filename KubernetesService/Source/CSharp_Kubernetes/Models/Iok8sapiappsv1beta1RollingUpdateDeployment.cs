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
    /// Spec to control the desired behavior of rolling update.
    /// </summary>
    public partial class Iok8sapiappsv1beta1RollingUpdateDeployment
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta1RollingUpdateDeployment class.
        /// </summary>
        public Iok8sapiappsv1beta1RollingUpdateDeployment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiappsv1beta1RollingUpdateDeployment class.
        /// </summary>
        /// <param name="maxSurge">The maximum number of pods that can be
        /// scheduled above the desired number of pods. Value can be an
        /// absolute number (ex: 5) or a percentage of desired pods (ex: 10%).
        /// This can not be 0 if MaxUnavailable is 0. Absolute number is
        /// calculated from percentage by rounding up. Defaults to 25%.
        /// Example: when this is set to 30%, the new RC can be scaled up
        /// immediately when the rolling update starts, such that the total
        /// number of old and new pods do not exceed 130% of desired pods. Once
        /// old pods have been killed, new RC can be scaled up further,
        /// ensuring that total number of pods running at any time during the
        /// update is atmost 130% of desired pods.</param>
        /// <param name="maxUnavailable">The maximum number of pods that can be
        /// unavailable during the update. Value can be an absolute number (ex:
        /// 5) or a percentage of desired pods (ex: 10%). Absolute number is
        /// calculated from percentage by rounding down. This can not be 0 if
        /// MaxSurge is 0. Defaults to 25%. Example: when this is set to 30%,
        /// the old RC can be scaled down to 70% of desired pods immediately
        /// when the rolling update starts. Once new pods are ready, old RC can
        /// be scaled down further, followed by scaling up the new RC, ensuring
        /// that the total number of pods available at all times during the
        /// update is at least 70% of desired pods.</param>
        public Iok8sapiappsv1beta1RollingUpdateDeployment(string maxSurge = default(string), string maxUnavailable = default(string))
        {
            MaxSurge = maxSurge;
            MaxUnavailable = maxUnavailable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum number of pods that can be scheduled above
        /// the desired number of pods. Value can be an absolute number (ex: 5)
        /// or a percentage of desired pods (ex: 10%). This can not be 0 if
        /// MaxUnavailable is 0. Absolute number is calculated from percentage
        /// by rounding up. Defaults to 25%. Example: when this is set to 30%,
        /// the new RC can be scaled up immediately when the rolling update
        /// starts, such that the total number of old and new pods do not
        /// exceed 130% of desired pods. Once old pods have been killed, new RC
        /// can be scaled up further, ensuring that total number of pods
        /// running at any time during the update is atmost 130% of desired
        /// pods.
        /// </summary>
        [JsonProperty(PropertyName = "maxSurge")]
        public string MaxSurge { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of pods that can be unavailable
        /// during the update. Value can be an absolute number (ex: 5) or a
        /// percentage of desired pods (ex: 10%). Absolute number is calculated
        /// from percentage by rounding down. This can not be 0 if MaxSurge is
        /// 0. Defaults to 25%. Example: when this is set to 30%, the old RC
        /// can be scaled down to 70% of desired pods immediately when the
        /// rolling update starts. Once new pods are ready, old RC can be
        /// scaled down further, followed by scaling up the new RC, ensuring
        /// that the total number of pods available at all times during the
        /// update is at least 70% of desired pods.
        /// </summary>
        [JsonProperty(PropertyName = "maxUnavailable")]
        public string MaxUnavailable { get; set; }

    }
}
