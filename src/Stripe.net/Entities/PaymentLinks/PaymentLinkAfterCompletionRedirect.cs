// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkAfterCompletionRedirect : StripeEntity<PaymentLinkAfterCompletionRedirect>
    {
        /// <summary>
        /// The URL the customer will be redirected to after the purchase is complete.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
