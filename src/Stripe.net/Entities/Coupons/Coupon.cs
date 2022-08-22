// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    /// <summary>
    /// A coupon contains information about a percent-off or amount-off discount you might want
    /// to apply to a customer. Coupons may be applied to <a
    /// href="https://stripe.com/docs/api#subscriptions">subscriptions</a>, <a
    /// href="https://stripe.com/docs/api#invoices">invoices</a>, <a
    /// href="https://stripe.com/docs/api/checkout/sessions">checkout sessions</a>, <a
    /// href="https://stripe.com/docs/api#quotes">quotes</a>, and more. Coupons do not work with
    /// conventional one-off <a href="https://stripe.com/docs/api#create_charge">charges</a> or
    /// <a href="https://stripe.com/docs/api/payment_intents">payment intents</a>.
    /// </summary>
    public class Coupon : StripeEntity<Coupon>, IHasId, IHasMetadata, IHasObject
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
        /// Amount (in the <c>currency</c> specified) that will be taken off the subtotal of any
        /// invoices for this customer.
        /// </summary>
        [JsonPropertyName("amount_off")]
        public long? AmountOff { get; set; }

        [JsonPropertyName("applies_to")]
        public CouponAppliesTo AppliesTo { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// If <c>amount_off</c> has been set, the three-letter <a
        /// href="https://stripe.com/docs/currencies">ISO code for the currency</a> of the amount to
        /// take off.
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Coupons defined in each available currency option. Each key must be a three-letter <a
        /// href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency code</a> and a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonPropertyName("currency_options")]
        public Dictionary<string, CouponCurrencyOptions> CurrencyOptions { get; set; }

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonPropertyName("deleted")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// One of <c>forever</c>, <c>once</c>, and <c>repeating</c>. Describes how long a customer
        /// who applies this coupon will get the discount.
        /// One of: <c>forever</c>, <c>once</c>, or <c>repeating</c>.
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// If <c>duration</c> is <c>repeating</c>, the number of months the coupon applies. Null if
        /// coupon <c>duration</c> is <c>forever</c> or <c>once</c>.
        /// </summary>
        [JsonPropertyName("duration_in_months")]
        public long? DurationInMonths { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Maximum number of times this coupon can be redeemed, in total, across all customers,
        /// before it is no longer valid.
        /// </summary>
        [JsonPropertyName("max_redemptions")]
        public long? MaxRedemptions { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Name of the coupon displayed to customers on for instance invoices or receipts.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Percent that will be taken off the subtotal of any invoices for this customer for the
        /// duration of the coupon. For example, a coupon with percent_off of 50 will make a %s100
        /// invoice %s50 instead.
        /// </summary>
        [JsonPropertyName("percent_off")]
        public decimal? PercentOff { get; set; }

        /// <summary>
        /// Date after which the coupon can no longer be redeemed.
        /// </summary>
        [JsonPropertyName("redeem_by")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? RedeemBy { get; set; }

        /// <summary>
        /// Number of times this coupon has been applied to a customer.
        /// </summary>
        [JsonPropertyName("times_redeemed")]
        public long TimesRedeemed { get; set; }

        /// <summary>
        /// Taking account of the above properties, whether this coupon can still be applied to a
        /// customer.
        /// </summary>
        [JsonPropertyName("valid")]
        public bool Valid { get; set; }
    }
}
