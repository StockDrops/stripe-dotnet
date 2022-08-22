// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// A Configurations object represents how features should be configured for terminal
    /// readers.
    /// </summary>
    public class Configuration : StripeEntity<Configuration>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("bbpos_wisepos_e")]
        public ConfigurationBbposWiseposE BbposWiseposE { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonPropertyName("deleted")]
[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Whether this Configuration is the default for your account.
        /// </summary>
        [JsonPropertyName("is_account_default")]
        public bool? IsAccountDefault { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("tipping")]
        public ConfigurationTipping Tipping { get; set; }

        [JsonPropertyName("verifone_p400")]
        public ConfigurationVerifoneP400 VerifoneP400 { get; set; }
    }
}
