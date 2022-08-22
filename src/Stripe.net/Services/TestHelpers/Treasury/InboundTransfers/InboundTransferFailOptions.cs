// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class InboundTransferFailOptions : BaseOptions
    {
        /// <summary>
        /// Details about a failed InboundTransfer.
        /// </summary>
        [JsonPropertyName("failure_details")]
        public InboundTransferFailureDetailsOptions FailureDetails { get; set; }
    }
}
