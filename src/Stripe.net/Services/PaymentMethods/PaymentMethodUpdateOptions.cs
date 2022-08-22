// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PaymentMethodUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonPropertyName("acss_debit")]
        public PaymentMethodAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonPropertyName("affirm")]
        public PaymentMethodAffirmOptions Affirm { get; set; }

        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonPropertyName("au_becs_debit")]
        public PaymentMethodAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonPropertyName("bacs_debit")]
        public PaymentMethodBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonPropertyName("billing_details")]
        public PaymentMethodBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonPropertyName("blik")]
        public PaymentMethodBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>card</c> PaymentMethod, this hash contains the user's card details.
        /// </summary>
        [JsonPropertyName("card")]
        public PaymentMethodCardOptions Card { get; set; }

        /// <summary>
        /// If this is an <c>Link</c> PaymentMethod, this hash contains details about the Link
        /// payment method.
        /// </summary>
        [JsonPropertyName("link")]
        public PaymentMethodLinkOptions Link { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// This is a legacy parameter that will be removed in the future. It is a hash that does
        /// not accept any keys.
        /// </summary>
        [JsonPropertyName("sepa_debit")]
        public PaymentMethodSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is an <c>us_bank_account</c> PaymentMethod, this hash contains details about the
        /// US bank account payment method.
        /// </summary>
        [JsonPropertyName("us_bank_account")]
        public PaymentMethodUsBankAccountOptions UsBankAccount { get; set; }
    }
}
