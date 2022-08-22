// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class PaymentIntentPaymentMethodOptionsKonbiniOptions : INestedOptions
    {
        /// <summary>
        /// An optional 10 to 11 digit numeric-only string determining the confirmation code at
        /// applicable convenience stores. Must not consist of only zeroes and could be rejected in
        /// case of insufficient uniqueness. We recommend to use the customer's phone number.
        /// </summary>
        [JsonPropertyName("confirmation_number")]
        public string ConfirmationNumber { get; set; }

        /// <summary>
        /// The number of calendar days (between 1 and 60) after which Konbini payment instructions
        /// will expire. For example, if a PaymentIntent is confirmed with Konbini and
        /// <c>expires_after_days</c> set to 2 on Monday JST, the instructions will expire on
        /// Wednesday 23:59:59 JST. Defaults to 3 days.
        /// </summary>
        [JsonPropertyName("expires_after_days")]
        public long? ExpiresAfterDays { get; set; }

        /// <summary>
        /// The timestamp at which the Konbini payment instructions will expire. Only one of
        /// <c>expires_after_days</c> or <c>expires_at</c> may be set.
        /// </summary>
        [JsonPropertyName("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A product descriptor of up to 22 characters, which will appear to customers at the
        /// convenience store.
        /// </summary>
        [JsonPropertyName("product_description")]
        public string ProductDescription { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// Providing this parameter will <a
        /// href="https://stripe.com/docs/payments/save-during-payment">attach the payment
        /// method</a> to the PaymentIntent's Customer, if present, after the PaymentIntent is
        /// confirmed and any required actions from the user are complete. If no Customer was
        /// provided, the payment method can still be <a
        /// href="https://stripe.com/docs/api/payment_methods/attach">attached</a> to a Customer
        /// after the transaction completes.
        ///
        /// When processing card payments, Stripe also uses <c>setup_future_usage</c> to dynamically
        /// optimize your payment flow and comply with regional legislation and network rules, such
        /// as <a href="https://stripe.com/docs/strong-customer-authentication">SCA</a>.
        ///
        /// If <c>setup_future_usage</c> is already set and you are performing a request using a
        /// publishable key, you may only update the value from <c>on_session</c> to
        /// <c>off_session</c>.
        /// </summary>
        [JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
