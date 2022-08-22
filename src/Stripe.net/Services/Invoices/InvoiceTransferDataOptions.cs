// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoiceTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount that will be transferred automatically when the invoice is paid. If no amount
        /// is set, the full amount is transferred.
        /// </summary>
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonPropertyName("destination")]
        public string Destination { get; set; }
    }
}
