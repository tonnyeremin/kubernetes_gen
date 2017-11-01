// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace KubernetesService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SubjectAccessReviewSpec is a description of the access request.
    /// Exactly one of ResourceAuthorizationAttributes and
    /// NonResourceAuthorizationAttributes must be set
    /// </summary>
    public partial class Iok8sapiauthorizationv1SubjectAccessReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SubjectAccessReviewSpec class.
        /// </summary>
        public Iok8sapiauthorizationv1SubjectAccessReviewSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SubjectAccessReviewSpec class.
        /// </summary>
        /// <param name="extra">Extra corresponds to the user.Info.GetExtra()
        /// method from the authenticator.  Since that is input to the
        /// authorizer it needs a reflection here.</param>
        /// <param name="groups">Groups is the groups you're testing
        /// for.</param>
        /// <param name="nonResourceAttributes">NonResourceAttributes describes
        /// information for a non-resource access request</param>
        /// <param name="resourceAttributes">ResourceAuthorizationAttributes
        /// describes information for a resource access request</param>
        /// <param name="uid">UID information about the requesting
        /// user.</param>
        /// <param name="user">User is the user you're testing for. If you
        /// specify "User" but not "Groups", then is it interpreted as "What if
        /// User were not a member of any groups</param>
        public Iok8sapiauthorizationv1SubjectAccessReviewSpec(IDictionary<string, IList<string>> extra = default(IDictionary<string, IList<string>>), IList<string> groups = default(IList<string>), Iok8sapiauthorizationv1NonResourceAttributes nonResourceAttributes = default(Iok8sapiauthorizationv1NonResourceAttributes), Iok8sapiauthorizationv1ResourceAttributes resourceAttributes = default(Iok8sapiauthorizationv1ResourceAttributes), string uid = default(string), string user = default(string))
        {
            Extra = extra;
            Groups = groups;
            NonResourceAttributes = nonResourceAttributes;
            ResourceAttributes = resourceAttributes;
            Uid = uid;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets extra corresponds to the user.Info.GetExtra() method
        /// from the authenticator.  Since that is input to the authorizer it
        /// needs a reflection here.
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public IDictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        /// Gets or sets groups is the groups you're testing for.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// Gets or sets nonResourceAttributes describes information for a
        /// non-resource access request
        /// </summary>
        [JsonProperty(PropertyName = "nonResourceAttributes")]
        public Iok8sapiauthorizationv1NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>
        /// Gets or sets resourceAuthorizationAttributes describes information
        /// for a resource access request
        /// </summary>
        [JsonProperty(PropertyName = "resourceAttributes")]
        public Iok8sapiauthorizationv1ResourceAttributes ResourceAttributes { get; set; }

        /// <summary>
        /// Gets or sets UID information about the requesting user.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets user is the user you're testing for. If you specify
        /// "User" but not "Groups", then is it interpreted as "What if User
        /// were not a member of any groups
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

    }
}
