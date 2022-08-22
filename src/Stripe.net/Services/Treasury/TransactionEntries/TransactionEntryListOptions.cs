// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class TransactionEntryListOptions : ListOptionsWithCreated
    {
        [JsonPropertyName("effective_at")]
        [JsonConverter(typeof(AnyOfConverterFactory))]
        public AnyOf<DateTime?, DateRangeOptions> EffectiveAt { get; set; }

        [JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        [JsonPropertyName("order_by")]
        public string OrderBy { get; set; }

        [JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
