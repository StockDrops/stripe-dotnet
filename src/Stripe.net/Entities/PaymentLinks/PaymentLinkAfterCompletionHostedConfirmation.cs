// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkAfterCompletionHostedConfirmation : StripeEntity<PaymentLinkAfterCompletionHostedConfirmation>
    {
        /// <summary>
        /// The custom message that is displayed to the customer after the purchase is complete.
        /// </summary>
        [JsonPropertyName("custom_message")]
        public string CustomMessage { get; set; }
    }
}
