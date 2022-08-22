// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Terminal
{
    using System.Text.Json.Serialization;

    public class ReaderPresentPaymentMethodOptions : BaseOptions
    {
        /// <summary>
        /// Simulated data for the card_present payment method.
        /// </summary>
        [JsonPropertyName("card_present")]
        public ReaderCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// Simulated payment type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
