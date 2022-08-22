// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentMethodCardOptions : INestedOptions
    {
        /// <summary>
        /// The card's CVC. It is highly recommended to always include this value.
        /// </summary>
        [JsonPropertyName("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
