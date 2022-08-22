// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentLinkPhoneNumberCollection : StripeEntity<PaymentLinkPhoneNumberCollection>
    {
        /// <summary>
        /// If <c>true</c>, a phone number will be collected during checkout.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
