// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System.Text.Json.Serialization;

    public class OutboundPaymentReturnOutboundPaymentOptions : BaseOptions
    {
        /// <summary>
        /// Optional hash to set the the return code.
        /// </summary>
        [JsonPropertyName("returned_details")]
        public OutboundPaymentReturnedDetailsOptions ReturnedDetails { get; set; }
    }
}
