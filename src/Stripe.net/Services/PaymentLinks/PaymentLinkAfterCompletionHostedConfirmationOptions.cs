// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkAfterCompletionHostedConfirmationOptions : INestedOptions
    {
        /// <summary>
        /// A custom message to display to the customer after the purchase is complete.
        /// </summary>
        [JsonPropertyName("custom_message")]
        public string CustomMessage { get; set; }
    }
}
