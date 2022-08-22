// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CouponCurrencyOptions : StripeEntity<CouponCurrencyOptions>
    {
        /// <summary>
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonPropertyName("amount_off")]
        public long AmountOff { get; set; }
    }
}
