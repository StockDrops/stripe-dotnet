// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class RefundNextAction : StripeEntity<RefundNextAction>
    {
        /// <summary>
        /// Contains the refund details.
        /// </summary>
        [JsonPropertyName("display_details")]
        public RefundNextActionDisplayDetails DisplayDetails { get; set; }

        /// <summary>
        /// Type of the next action to perform.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
