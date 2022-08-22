// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhaseTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice subtotal that will be transferred
        /// to the destination account. By default, the entire amount is transferred to the
        /// destination.
        /// </summary>
        [JsonPropertyName("amount_percent")]
        public decimal? AmountPercent { get; set; }

        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonPropertyName("destination")]
        public string Destination { get; set; }
    }
}
