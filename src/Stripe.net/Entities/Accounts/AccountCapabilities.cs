// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class AccountCapabilities : StripeEntity<AccountCapabilities>
    {
        /// <summary>
        /// The status of the Canadian pre-authorized debits payments capability of the account, or
        /// whether the account can directly process Canadian pre-authorized debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("acss_debit_payments")]
        public string AcssDebitPayments { get; set; }

        /// <summary>
        /// The status of the Affirm capability of the account, or whether the account can directly
        /// process Affirm charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("affirm_payments")]
        public string AffirmPayments { get; set; }

        /// <summary>
        /// The status of the Afterpay Clearpay capability of the account, or whether the account
        /// can directly process Afterpay Clearpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("afterpay_clearpay_payments")]
        public string AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The status of the BECS Direct Debit (AU) payments capability of the account, or whether
        /// the account can directly process BECS Direct Debit (AU) charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("au_becs_debit_payments")]
        public string AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bacs Direct Debits payments capability of the account, or whether the
        /// account can directly process Bacs Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("bacs_debit_payments")]
        public string BacsDebitPayments { get; set; }

        /// <summary>
        /// The status of the Bancontact payments capability of the account, or whether the account
        /// can directly process Bancontact charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("bancontact_payments")]
        public string BancontactPayments { get; set; }

        /// <summary>
        /// The status of the customer_balance payments capability of the account, or whether the
        /// account can directly process customer_balance charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("bank_transfer_payments")]
        public string BankTransferPayments { get; set; }

        /// <summary>
        /// The status of the blik payments capability of the account, or whether the account can
        /// directly process blik charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("blik_payments")]
        public string BlikPayments { get; set; }

        /// <summary>
        /// The status of the boleto payments capability of the account, or whether the account can
        /// directly process boleto charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("boleto_payments")]
        public string BoletoPayments { get; set; }

        /// <summary>
        /// The status of the card issuing capability of the account, or whether you can use Issuing
        /// to distribute funds on cards.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("card_issuing")]
        public string CardIssuing { get; set; }

        /// <summary>
        /// The status of the card payments capability of the account, or whether the account can
        /// directly process credit and debit card charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("card_payments")]
        public string CardPayments { get; set; }

        /// <summary>
        /// The status of the Cartes Bancaires payments capability of the account, or whether the
        /// account can directly process Cartes Bancaires card charges in EUR currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("cartes_bancaires_payments")]
        public string CartesBancairesPayments { get; set; }

        /// <summary>
        /// The status of the EPS payments capability of the account, or whether the account can
        /// directly process EPS charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("eps_payments")]
        public string EpsPayments { get; set; }

        /// <summary>
        /// The status of the FPX payments capability of the account, or whether the account can
        /// directly process FPX charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("fpx_payments")]
        public string FpxPayments { get; set; }

        /// <summary>
        /// The status of the giropay payments capability of the account, or whether the account can
        /// directly process giropay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("giropay_payments")]
        public string GiropayPayments { get; set; }

        /// <summary>
        /// The status of the GrabPay payments capability of the account, or whether the account can
        /// directly process GrabPay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("grabpay_payments")]
        public string GrabpayPayments { get; set; }

        /// <summary>
        /// The status of the iDEAL payments capability of the account, or whether the account can
        /// directly process iDEAL charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("ideal_payments")]
        public string IdealPayments { get; set; }

        /// <summary>
        /// The status of the JCB payments capability of the account, or whether the account (Japan
        /// only) can directly process JCB credit card charges in JPY currency.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("jcb_payments")]
        public string JcbPayments { get; set; }

        /// <summary>
        /// The status of the Klarna payments capability of the account, or whether the account can
        /// directly process Klarna charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("klarna_payments")]
        public string KlarnaPayments { get; set; }

        /// <summary>
        /// The status of the konbini payments capability of the account, or whether the account can
        /// directly process konbini charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("konbini_payments")]
        public string KonbiniPayments { get; set; }

        /// <summary>
        /// The status of the legacy payments capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("legacy_payments")]
        public string LegacyPayments { get; set; }

        /// <summary>
        /// The status of the link_payments capability of the account, or whether the account can
        /// directly process Link charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("link_payments")]
        public string LinkPayments { get; set; }

        /// <summary>
        /// The status of the OXXO payments capability of the account, or whether the account can
        /// directly process OXXO charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("oxxo_payments")]
        public string OxxoPayments { get; set; }

        /// <summary>
        /// The status of the P24 payments capability of the account, or whether the account can
        /// directly process P24 charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("p24_payments")]
        public string P24Payments { get; set; }

        /// <summary>
        /// The status of the paynow payments capability of the account, or whether the account can
        /// directly process paynow charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("paynow_payments")]
        public string PaynowPayments { get; set; }

        /// <summary>
        /// The status of the promptpay payments capability of the account, or whether the account
        /// can directly process promptpay charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("promptpay_payments")]
        public string PromptpayPayments { get; set; }

        /// <summary>
        /// The status of the SEPA Direct Debits payments capability of the account, or whether the
        /// account can directly process SEPA Direct Debits charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("sepa_debit_payments")]
        public string SepaDebitPayments { get; set; }

        /// <summary>
        /// The status of the Sofort payments capability of the account, or whether the account can
        /// directly process Sofort charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("sofort_payments")]
        public string SofortPayments { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-K (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("tax_reporting_us_1099_k")]
        public string TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The status of the tax reporting 1099-MISC (US) capability of the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("tax_reporting_us_1099_misc")]
        public string TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The status of the transfers capability of the account, or whether your platform can
        /// transfer funds to the account.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("transfers")]
        public string Transfers { get; set; }

        /// <summary>
        /// The status of the banking capability, or whether the account can have bank accounts.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("treasury")]
        public string Treasury { get; set; }

        /// <summary>
        /// The status of the US bank account ACH payments capability of the account, or whether the
        /// account can directly process US bank account charges.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonPropertyName("us_bank_account_ach_payments")]
        public string UsBankAccountAchPayments { get; set; }
    }
}
