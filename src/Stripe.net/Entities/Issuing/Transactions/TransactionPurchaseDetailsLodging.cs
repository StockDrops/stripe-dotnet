// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsLodging : StripeEntity<TransactionPurchaseDetailsLodging>
    {
        /// <summary>
        /// The time of checking into the lodging.
        /// </summary>
        [JsonPropertyName("check_in_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CheckInAt { get; set; }

        /// <summary>
        /// The number of nights stayed at the lodging.
        /// </summary>
        [JsonPropertyName("nights")]
        public long? Nights { get; set; }
    }
}
