namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargePaymentMethodDetailsBitcoin : StripeEntity<ChargePaymentMethodDetailsBitcoin>
    {
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("amount_charged")]
        public long? AmountCharged { get; set; }

        [JsonPropertyName("amount_received")]
        public long? AmountReceived { get; set; }

        [JsonPropertyName("amount_returned")]
        public long? AmountReturned { get; set; }

        [JsonPropertyName("refund_address")]
        public string RefundAddress { get; set; }
    }
}
