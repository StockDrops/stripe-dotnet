// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// The acss_debit_payments capability.
        /// </summary>
        [JsonPropertyName("acss_debit_payments")]
        public AccountCapabilitiesAcssDebitPaymentsOptions AcssDebitPayments { get; set; }

        /// <summary>
        /// The affirm_payments capability.
        /// </summary>
        [JsonPropertyName("affirm_payments")]
        public AccountCapabilitiesAffirmPaymentsOptions AffirmPayments { get; set; }

        /// <summary>
        /// The afterpay_clearpay_payments capability.
        /// </summary>
        [JsonPropertyName("afterpay_clearpay_payments")]
        public AccountCapabilitiesAfterpayClearpayPaymentsOptions AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The au_becs_debit_payments capability.
        /// </summary>
        [JsonPropertyName("au_becs_debit_payments")]
        public AccountCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The bacs_debit_payments capability.
        /// </summary>
        [JsonPropertyName("bacs_debit_payments")]
        public AccountCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// The bancontact_payments capability.
        /// </summary>
        [JsonPropertyName("bancontact_payments")]
        public AccountCapabilitiesBancontactPaymentsOptions BancontactPayments { get; set; }

        /// <summary>
        /// The bank_transfer_payments capability.
        /// </summary>
        [JsonPropertyName("bank_transfer_payments")]
        public AccountCapabilitiesBankTransferPaymentsOptions BankTransferPayments { get; set; }

        /// <summary>
        /// The blik_payments capability.
        /// </summary>
        [JsonPropertyName("blik_payments")]
        public AccountCapabilitiesBlikPaymentsOptions BlikPayments { get; set; }

        /// <summary>
        /// The boleto_payments capability.
        /// </summary>
        [JsonPropertyName("boleto_payments")]
        public AccountCapabilitiesBoletoPaymentsOptions BoletoPayments { get; set; }

        /// <summary>
        /// The card_issuing capability.
        /// </summary>
        [JsonPropertyName("card_issuing")]
        public AccountCapabilitiesCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// The card_payments capability.
        /// </summary>
        [JsonPropertyName("card_payments")]
        public AccountCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// The cartes_bancaires_payments capability.
        /// </summary>
        [JsonPropertyName("cartes_bancaires_payments")]
        public AccountCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// The eps_payments capability.
        /// </summary>
        [JsonPropertyName("eps_payments")]
        public AccountCapabilitiesEpsPaymentsOptions EpsPayments { get; set; }

        /// <summary>
        /// The fpx_payments capability.
        /// </summary>
        [JsonPropertyName("fpx_payments")]
        public AccountCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// The giropay_payments capability.
        /// </summary>
        [JsonPropertyName("giropay_payments")]
        public AccountCapabilitiesGiropayPaymentsOptions GiropayPayments { get; set; }

        /// <summary>
        /// The grabpay_payments capability.
        /// </summary>
        [JsonPropertyName("grabpay_payments")]
        public AccountCapabilitiesGrabpayPaymentsOptions GrabpayPayments { get; set; }

        /// <summary>
        /// The ideal_payments capability.
        /// </summary>
        [JsonPropertyName("ideal_payments")]
        public AccountCapabilitiesIdealPaymentsOptions IdealPayments { get; set; }

        /// <summary>
        /// The jcb_payments capability.
        /// </summary>
        [JsonPropertyName("jcb_payments")]
        public AccountCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// The klarna_payments capability.
        /// </summary>
        [JsonPropertyName("klarna_payments")]
        public AccountCapabilitiesKlarnaPaymentsOptions KlarnaPayments { get; set; }

        /// <summary>
        /// The konbini_payments capability.
        /// </summary>
        [JsonPropertyName("konbini_payments")]
        public AccountCapabilitiesKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// The legacy_payments capability.
        /// </summary>
        [JsonPropertyName("legacy_payments")]
        public AccountCapabilitiesLegacyPaymentsOptions LegacyPayments { get; set; }

        /// <summary>
        /// The link_payments capability.
        /// </summary>
        [JsonPropertyName("link_payments")]
        public AccountCapabilitiesLinkPaymentsOptions LinkPayments { get; set; }

        /// <summary>
        /// The oxxo_payments capability.
        /// </summary>
        [JsonPropertyName("oxxo_payments")]
        public AccountCapabilitiesOxxoPaymentsOptions OxxoPayments { get; set; }

        /// <summary>
        /// The p24_payments capability.
        /// </summary>
        [JsonPropertyName("p24_payments")]
        public AccountCapabilitiesP24PaymentsOptions P24Payments { get; set; }

        /// <summary>
        /// The paynow_payments capability.
        /// </summary>
        [JsonPropertyName("paynow_payments")]
        public AccountCapabilitiesPaynowPaymentsOptions PaynowPayments { get; set; }

        /// <summary>
        /// The promptpay_payments capability.
        /// </summary>
        [JsonPropertyName("promptpay_payments")]
        public AccountCapabilitiesPromptpayPaymentsOptions PromptpayPayments { get; set; }

        /// <summary>
        /// The sepa_debit_payments capability.
        /// </summary>
        [JsonPropertyName("sepa_debit_payments")]
        public AccountCapabilitiesSepaDebitPaymentsOptions SepaDebitPayments { get; set; }

        /// <summary>
        /// The sofort_payments capability.
        /// </summary>
        [JsonPropertyName("sofort_payments")]
        public AccountCapabilitiesSofortPaymentsOptions SofortPayments { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_k capability.
        /// </summary>
        [JsonPropertyName("tax_reporting_us_1099_k")]
        public AccountCapabilitiesTaxReportingUs1099KOptions TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_misc capability.
        /// </summary>
        [JsonPropertyName("tax_reporting_us_1099_misc")]
        public AccountCapabilitiesTaxReportingUs1099MiscOptions TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The transfers capability.
        /// </summary>
        [JsonPropertyName("transfers")]
        public AccountCapabilitiesTransfersOptions Transfers { get; set; }

        /// <summary>
        /// The treasury capability.
        /// </summary>
        [JsonPropertyName("treasury")]
        public AccountCapabilitiesTreasuryOptions Treasury { get; set; }

        /// <summary>
        /// The us_bank_account_ach_payments capability.
        /// </summary>
        [JsonPropertyName("us_bank_account_ach_payments")]
        public AccountCapabilitiesUsBankAccountAchPaymentsOptions UsBankAccountAchPayments { get; set; }
    }
}
