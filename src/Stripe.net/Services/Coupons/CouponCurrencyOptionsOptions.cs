// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CouponCurrencyOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer representing the amount to subtract from an invoice total.
        /// </summary>
        [JsonPropertyName("amount_off")]
        public long? AmountOff { get; set; }
    }
}
