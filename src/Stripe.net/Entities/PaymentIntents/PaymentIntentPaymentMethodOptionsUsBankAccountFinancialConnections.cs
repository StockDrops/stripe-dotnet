// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
        /// <summary>
        /// The list of permissions to request. The <c>payment_method</c> permission must be
        /// included.
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
