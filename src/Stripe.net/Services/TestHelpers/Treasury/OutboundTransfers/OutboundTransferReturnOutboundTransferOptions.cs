// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundTransferReturnOutboundTransferOptions : BaseOptions
    {
        /// <summary>
        /// Details about a returned OutboundTransfer.
        /// </summary>
        [JsonPropertyName("returned_details")]
        public OutboundTransferReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
