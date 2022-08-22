namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SourceTransaction : StripeEntity<SourceTransaction>, IHasId, IHasObject
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("customer_data")]
        public string CustomerData { get; set; }

        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("ach_credit_transfer")]
        public SourceTransactionAchCreditTransfer AchCreditTransfer { get; set; }

        [JsonPropertyName("sepa_credit_transfer")]
        public SourceTransactionSepaCreditTransfer SepaCreditTransfer { get; set; }
    }
}
