// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentCancelOptions : BaseOptions
    {
        /// <summary>
        /// Reason for canceling this PaymentIntent. Possible values are <c>duplicate</c>,
        /// <c>fraudulent</c>, <c>requested_by_customer</c>, or <c>abandoned</c>.
        /// One of: <c>abandoned</c>, <c>duplicate</c>, <c>fraudulent</c>, or
        /// <c>requested_by_customer</c>.
        /// </summary>
        [JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
