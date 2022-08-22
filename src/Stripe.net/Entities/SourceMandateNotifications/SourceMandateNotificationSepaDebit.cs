namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceMandateNotificationSepaDebit : StripeEntity<SourceMandateNotificationSepaDebit>
    {
        [JsonPropertyName("creditor_identifier")]
        public string CreditorIdentifier { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("mandate_reference")]
        public string MandateReference { get; set; }
    }
}
