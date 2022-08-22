// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// Shipping rates describe the price of shipping presented to your customers and can be
    /// applied to <a href="https://stripe.com/docs/payments/checkout/shipping">Checkout
    /// Sessions</a> and <a href="https://stripe.com/docs/orders/shipping">Orders</a> to collect
    /// shipping costs.
    /// </summary>
    public class ShippingRate : StripeEntity<ShippingRate>, IHasId, IHasMetadata, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Whether the shipping rate can be used for new purchases. Defaults to <c>true</c>.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The estimated range for how long shipping will take, meant to be displayable to the
        /// customer. This will appear on CheckoutSessions.
        /// </summary>
        [JsonPropertyName("delivery_estimate")]
        public ShippingRateDeliveryEstimate DeliveryEstimate { get; set; }

        /// <summary>
        /// The name of the shipping rate, meant to be displayable to the customer. This will appear
        /// on CheckoutSessions.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        [JsonPropertyName("fixed_amount")]
        public ShippingRateFixedAmount FixedAmount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
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

        #region Expandable TaxCode

        /// <summary>
        /// (ID of the TaxCode)
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID. The Shipping tax
        /// code is <c>txcd_92010001</c>.
        /// </summary>
        [JsonIgnore]
        public string TaxCodeId
        {
            get => this.InternalTaxCode?.Id;
            set => this.InternalTaxCode = SetExpandableFieldId(value, this.InternalTaxCode);
        }

        /// <summary>
        /// (Expanded)
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID. The Shipping tax
        /// code is <c>txcd_92010001</c>.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        public TaxCode TaxCode
        {
            get => this.InternalTaxCode?.ExpandedObject;
            set => this.InternalTaxCode = SetExpandableFieldObject(value, this.InternalTaxCode);
        }

        [JsonPropertyName("tax_code")]
        [JsonConverter(typeof(ExpandableFieldConverter<TaxCode>))]
        internal ExpandableField<TaxCode> InternalTaxCode { get; set; }
        #endregion

        /// <summary>
        /// The type of calculation to use on the shipping rate. Can only be <c>fixed_amount</c> for
        /// now.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
