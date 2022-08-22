namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleInvoiceSettings : StripeEntity<SubscriptionScheduleInvoiceSettings>
    {
        [JsonPropertyName("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
