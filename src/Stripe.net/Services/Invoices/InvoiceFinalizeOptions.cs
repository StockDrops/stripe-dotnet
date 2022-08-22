// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class InvoiceFinalizeOptions : BaseOptions
    {
        /// <summary>
        /// Controls whether Stripe will perform <a
        /// href="https://stripe.com/docs/invoicing/automatic-charging">automatic collection</a> of
        /// the invoice. When <c>false</c>, the invoice's state will not automatically advance
        /// without an explicit action.
        /// </summary>
        [JsonPropertyName("auto_advance")]
        public bool? AutoAdvance { get; set; }
    }
}
