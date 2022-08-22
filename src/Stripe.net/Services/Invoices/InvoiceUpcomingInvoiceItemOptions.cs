namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class InvoiceUpcomingInvoiceItemOptions : INestedOptions, IHasMetadata
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("discountable")]
        public bool? Discountable { get; set; }

        [JsonPropertyName("discounts")]
        public List<InvoiceItemDiscountOptions> Discounts { get; set; }

        [JsonPropertyName("invoiceitem")]
        [AllowNameMismatch]
        public string InvoiceItem { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonPropertyName("period")]
        public InvoiceItemPeriodOptions Period { get; set; }

        [JsonPropertyName("price")]
        public string Price { get; set; }

        [JsonPropertyName("price_data")]
        public InvoiceItemPriceDataOptions PriceData { get; set; }

        [JsonPropertyName("quantity")]
        public long? Quantity { get; set; }

        [JsonPropertyName("tax_rates")]
        public List<string> TaxRates { get; set; }

        [JsonPropertyName("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonPropertyName("unit_amount_decimal")]
        public decimal? UnitAmountDecimal { get; set; }
    }
}
