// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// Value list items allow you to add specific values to a given Radar value list, which can
    /// then be used in rules.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/docs/radar/lists#managing-list-items">Managing List Items</a>.
    /// </summary>
    public class ValueListItem : StripeEntity<ValueListItem>, IHasId, IHasObject
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

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The name or email address of the user who added this item to the value list.
        /// </summary>
        [JsonPropertyName("created_by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The value of the item.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// The identifier of the value list this item belongs to.
        /// </summary>
        [JsonPropertyName("value_list")]
        public string ValueList { get; set; }
    }
}
