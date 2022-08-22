// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkAfterCompletionOptions : INestedOptions
    {
        /// <summary>
        /// Configuration when <c>type=hosted_confirmation</c>.
        /// </summary>
        [JsonPropertyName("hosted_confirmation")]
        public PaymentLinkAfterCompletionHostedConfirmationOptions HostedConfirmation { get; set; }

        /// <summary>
        /// Configuration when <c>type=redirect</c>.
        /// </summary>
        [JsonPropertyName("redirect")]
        public PaymentLinkAfterCompletionRedirectOptions Redirect { get; set; }

        /// <summary>
        /// The specified behavior after the purchase is complete. Either <c>redirect</c> or
        /// <c>hosted_confirmation</c>.
        /// One of: <c>hosted_confirmation</c>, or <c>redirect</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
