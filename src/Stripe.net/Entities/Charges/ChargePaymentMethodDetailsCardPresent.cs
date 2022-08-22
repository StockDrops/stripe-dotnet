// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardPresent : StripeEntity<ChargePaymentMethodDetailsCardPresent>
    {
        /// <summary>
        /// The authorized amount.
        /// </summary>
        [JsonPropertyName("amount_authorized")]
        public long? AmountAuthorized { get; set; }

        /// <summary>
        /// Card brand. Can be <c>amex</c>, <c>diners</c>, <c>discover</c>, <c>jcb</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// When using manual capture, a future timestamp after which the charge will be
        /// automatically refunded if uncaptured.
        /// </summary>
        [JsonPropertyName("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The cardholder name as read from the card, in <a
        /// href="https://en.wikipedia.org/wiki/ISO/IEC_7813">ISO 7813</a> format. May include
        /// alphanumeric characters, special characters and first/last name separator (<c>/</c>). In
        /// some cases, the cardholder name may not be available depending on how the issuer has
        /// configured the card. Cardholder name is typically not available on swipe or contactless
        /// payments, such as those made with Apple Pay and Google Pay.
        /// </summary>
        [JsonPropertyName("cardholder_name")]
        public string CardholderName { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country of the card. You could use this attribute
        /// to get a sense of the international breakdown of cards you've collected.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// A high-level description of the type of cards issued in this range. (For internal use
        /// only and not typically available in standard API requests.).
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Authorization response cryptogram.
        /// </summary>
        [JsonPropertyName("emv_auth_data")]
        public string EmvAuthData { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonPropertyName("exp_month")]
        public long ExpMonth { get; set; }

        /// <summary>
        /// Four-digit number representing the card's expiration year.
        /// </summary>
        [JsonPropertyName("exp_year")]
        public long ExpYear { get; set; }

        /// <summary>
        /// Uniquely identifies this particular card number. You can use this attribute to check
        /// whether two customers who’ve signed up with you are using the same card number, for
        /// example. For payment methods that tokenize card information (Apple Pay, Google Pay), the
        /// tokenized number might be provided instead of the underlying card number.
        ///
        /// <em>Starting May 1, 2021, card fingerprint in India for Connect will change to allow two
        /// fingerprints for the same card --- one for India and one for the rest of the world.</em>.
        /// </summary>
        [JsonPropertyName("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Card funding type. Can be <c>credit</c>, <c>debit</c>, <c>prepaid</c>, or
        /// <c>unknown</c>.
        /// </summary>
        [JsonPropertyName("funding")]
        public string Funding { get; set; }

        /// <summary>
        /// ID of a card PaymentMethod generated from the card_present PaymentMethod that may be
        /// attached to a Customer for future transactions. Only present if it was possible to
        /// generate a card PaymentMethod.
        /// </summary>
        [JsonPropertyName("generated_card")]
        public string GeneratedCard { get; set; }

        /// <summary>
        /// Issuer identification number of the card. (For internal use only and not typically
        /// available in standard API requests.).
        /// </summary>
        [JsonPropertyName("iin")]
        public string Iin { get; set; }

        /// <summary>
        /// Whether this <a href="https://stripe.com/docs/api/payment_intents">PaymentIntent</a> is
        /// eligible for incremental authorizations. Request support using <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-payment_method_options-card_present-request_incremental_authorization_support">request_incremental_authorization_support</a>.
        /// </summary>
        [JsonPropertyName("incremental_authorization_supported")]
        public bool? IncrementalAuthorizationSupported { get; set; }

        /// <summary>
        /// The name of the card's issuing bank. (For internal use only and not typically available
        /// in standard API requests.).
        /// </summary>
        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        /// <summary>
        /// The last four digits of the card.
        /// </summary>
        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Identifies which network this charge was processed on. Can be <c>amex</c>,
        /// <c>cartes_bancaires</c>, <c>diners</c>, <c>discover</c>, <c>interac</c>, <c>jcb</c>,
        /// <c>mastercard</c>, <c>unionpay</c>, <c>visa</c>, or <c>unknown</c>.
        /// </summary>
        [JsonPropertyName("network")]
        public string Network { get; set; }

        /// <summary>
        /// Defines whether the authorized amount can be over-captured or not.
        /// </summary>
        [JsonPropertyName("overcapture_supported")]
        public bool? OvercaptureSupported { get; set; }

        /// <summary>
        /// How card details were read in this transaction.
        /// One of: <c>contact_emv</c>, <c>contactless_emv</c>, <c>contactless_magstripe_mode</c>,
        /// <c>magnetic_stripe_fallback</c>, or <c>magnetic_stripe_track2</c>.
        /// </summary>
        [JsonPropertyName("read_method")]
        public string ReadMethod { get; set; }

        /// <summary>
        /// A collection of fields required to be displayed on receipts. Only required for EMV
        /// transactions.
        /// </summary>
        [JsonPropertyName("receipt")]
        public ChargePaymentMethodDetailsCardPresentReceipt Receipt { get; set; }
    }
}
