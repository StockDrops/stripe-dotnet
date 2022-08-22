// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class SessionShippingOptionShippingRateDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The estimated range for how long shipping will take, meant to be displayable to the
        /// customer. This will appear on CheckoutSessions.
        /// </summary>
        [JsonPropertyName("delivery_estimate")]
        public SessionShippingOptionShippingRateDataDeliveryEstimateOptions DeliveryEstimate { get; set; }

        /// <summary>
        /// The name of the shipping rate, meant to be displayable to the customer. This will appear
        /// on CheckoutSessions.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Describes a fixed amount to charge for shipping. Must be present if type is
        /// <c>fixed_amount</c>.
        /// </summary>
        [JsonPropertyName("fixed_amount")]
        public SessionShippingOptionShippingRateDataFixedAmountOptions FixedAmount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One
        /// of <c>inclusive</c>, <c>exclusive</c>, or <c>unspecified</c>.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonPropertyName("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID. The Shipping tax
        /// code is <c>txcd_92010001</c>.
        /// </summary>
        [JsonPropertyName("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// The type of calculation to use on the shipping rate. Can only be <c>fixed_amount</c> for
        /// now.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
