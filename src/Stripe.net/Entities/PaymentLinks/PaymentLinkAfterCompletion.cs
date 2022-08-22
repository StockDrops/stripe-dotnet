// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkAfterCompletion : StripeEntity<PaymentLinkAfterCompletion>
    {
        [JsonPropertyName("hosted_confirmation")]
        public PaymentLinkAfterCompletionHostedConfirmation HostedConfirmation { get; set; }

        [JsonPropertyName("redirect")]
        public PaymentLinkAfterCompletionRedirect Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the purchase is complete.
        /// One of: <c>hosted_confirmation</c>, or <c>redirect</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
