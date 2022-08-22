// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class CardholderSpendingControlsSpendingLimitOptions : INestedOptions
    {
        /// <summary>
        /// Maximum amount allowed to spend per interval.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Array of strings containing <a
        /// href="https://stripe.com/docs/api#issuing_authorization_object-merchant_data-category">categories</a>
        /// this limit applies to. Omitting this field will apply the limit to all categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Interval (or event) to which the amount applies.
        /// One of: <c>all_time</c>, <c>daily</c>, <c>monthly</c>, <c>per_authorization</c>,
        /// <c>weekly</c>, or <c>yearly</c>.
        /// </summary>
        [JsonPropertyName("interval")]
        public string Interval { get; set; }
    }
}
