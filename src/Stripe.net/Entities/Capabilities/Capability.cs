// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// This is an object representing a capability for a Stripe account.
    ///
    /// Related guide: <a href="https://stripe.com/docs/connect/account-capabilities">Account
    /// capabilities</a>.
    /// </summary>
    public class Capability : StripeEntity<Capability>, IHasId, IHasObject
    {
        /// <summary>
        /// The identifier for the capability.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        #region Expandable Account

        /// <summary>
        /// (ID of the Account)
        /// The account for which the capability enables functionality.
        /// </summary>
        [JsonIgnore]
        public string AccountId
        {
            get => this.InternalAccount?.Id;
            set => this.InternalAccount = SetExpandableFieldId(value, this.InternalAccount);
        }

        /// <summary>
        /// (Expanded)
        /// The account for which the capability enables functionality.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public Account Account
        {
            get => this.InternalAccount?.ExpandedObject;
            set => this.InternalAccount = SetExpandableFieldObject(value, this.InternalAccount);
        }

        [JsonPropertyName("account")]
        [JsonConverter(typeof(ExpandableFieldConverter<Account>))]
        [JsonInclude]
        public ExpandableField<Account> InternalAccount { get; private set; }
        #endregion

        [JsonPropertyName("future_requirements")]
        public CapabilityFutureRequirements FutureRequirements { get; set; }

        /// <summary>
        /// Whether the capability has been requested.
        /// </summary>
        [JsonPropertyName("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Time at which the capability was requested. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("requested_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RequestedAt { get; set; }

        [JsonPropertyName("requirements")]
        public CapabilityRequirements Requirements { get; set; }

        /// <summary>
        /// The status of the capability. Can be <c>active</c>, <c>inactive</c>, <c>pending</c>, or
        /// <c>unrequested</c>.
        /// One of: <c>active</c>, <c>disabled</c>, <c>inactive</c>, <c>pending</c>, or
        /// <c>unrequested</c>.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
