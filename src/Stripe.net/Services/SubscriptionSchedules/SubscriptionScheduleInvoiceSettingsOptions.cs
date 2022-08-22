namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionScheduleInvoiceSettingsOptions : INestedOptions
    {
        [JsonPropertyName("days_until_due")]
        public long? DaysUntilDue { get; set; }
    }
}
