// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SubscriptionSchedulePhaseAddInvoiceItemOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new <a href="https://stripe.com/docs/api/prices">Price</a>
        /// object inline.
        /// </summary>
        [JsonPropertyName("price_data")]
        public SubscriptionSchedulePhaseAddInvoiceItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item. Defaults to 1.
        /// </summary>
        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// The tax rates which apply to the item. When set, the <c>default_tax_rates</c> do not
        /// apply to this item.
        /// </summary>
        [JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
