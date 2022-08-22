namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceTransactionSepaCreditTransfer : StripeEntity<SourceTransactionSepaCreditTransfer>
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("sender_iban")]
        public string SenderIban { get; set; }

        [JsonPropertyName("sender_name")]
        public string SenderName { get; set; }
    }
}
