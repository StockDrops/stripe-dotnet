// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentNextActionKonbiniDisplayDetailsStores : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetailsStores>
    {
        /// <summary>
        /// FamilyMart instruction details.
        /// </summary>
        [JsonPropertyName("familymart")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresFamilymart Familymart { get; set; }

        /// <summary>
        /// Lawson instruction details.
        /// </summary>
        [JsonPropertyName("lawson")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresLawson Lawson { get; set; }

        /// <summary>
        /// Ministop instruction details.
        /// </summary>
        [JsonPropertyName("ministop")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresMinistop Ministop { get; set; }

        /// <summary>
        /// Seicomart instruction details.
        /// </summary>
        [JsonPropertyName("seicomart")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStoresSeicomart Seicomart { get; set; }
    }
}
