// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System.Text.Json.Serialization;

    public class DisputeTreasuryOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the ReceivedDebit to initiate an Issuings dispute for.
        /// </summary>
        [JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
