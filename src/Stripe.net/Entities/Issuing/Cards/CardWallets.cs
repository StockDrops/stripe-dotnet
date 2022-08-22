// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class CardWallets : StripeEntity<CardWallets>
    {
        [JsonPropertyName("apple_pay")]
        public CardWalletsApplePay ApplePay { get; set; }

        [JsonPropertyName("google_pay")]
        public CardWalletsGooglePay GooglePay { get; set; }

        /// <summary>
        /// Unique identifier for a card used with digital wallets.
        /// </summary>
        [JsonPropertyName("primary_account_identifier")]
        public string PrimaryAccountIdentifier { get; set; }
    }
}
