// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class TransactionPurchaseDetailsReceipt : StripeEntity<TransactionPurchaseDetailsReceipt>
    {
        /// <summary>
        /// The description of the item. The maximum length of this field is 26 characters.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The quantity of the item.
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The total for this line item in cents.
        /// </summary>
        [JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// The unit cost of the item in cents.
        /// </summary>
        [JsonPropertyName("unit_cost")]
        public long? UnitCost { get; set; }
    }
}
