namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SourceMandateNotification : StripeEntity<SourceMandateNotification>, IHasId, IHasObject
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

        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        [JsonPropertyName("source")]
        public Source Source { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("sepa_debit")]
        public SourceMandateNotificationSepaDebit SepaDebit { get; set; }
    }
}
