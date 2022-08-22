// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer : StripeEntity<PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransfer>
    {
        [JsonPropertyName("eu_bank_transfer")]
        public PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer EuBankTransfer { get; set; }

        /// <summary>
        /// List of address types that should be returned in the financial_addresses response. If
        /// not specified, all valid types will be returned.
        ///
        /// Permitted values include: <c>sort_code</c>, <c>zengin</c>, <c>iban</c>, or <c>spei</c>.
        /// </summary>
        [JsonPropertyName("requested_address_types")]
        public List<string> RequestedAddressTypes { get; set; }

        /// <summary>
        /// The bank transfer type that this PaymentIntent is allowed to use for funding Permitted
        /// values include: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>,
        /// <c>jp_bank_transfer</c>, or <c>mx_bank_transfer</c>.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>, or
        /// <c>mx_bank_transfer</c>.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
