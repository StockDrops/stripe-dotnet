// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SourceKlarna : StripeEntity<SourceKlarna>
    {
        [JsonPropertyName("background_image_url")]
        public string BackgroundImageUrl { get; set; }

        [JsonPropertyName("client_token")]
        public string ClientToken { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("logo_url")]
        public string LogoUrl { get; set; }

        [JsonPropertyName("page_title")]
        public string PageTitle { get; set; }

        [JsonPropertyName("pay_later_asset_urls_descriptive")]
        public string PayLaterAssetUrlsDescriptive { get; set; }

        [JsonPropertyName("pay_later_asset_urls_standard")]
        public string PayLaterAssetUrlsStandard { get; set; }

        [JsonPropertyName("pay_later_name")]
        public string PayLaterName { get; set; }

        [JsonPropertyName("pay_later_redirect_url")]
        public string PayLaterRedirectUrl { get; set; }

        [JsonPropertyName("pay_now_asset_urls_descriptive")]
        public string PayNowAssetUrlsDescriptive { get; set; }

        [JsonPropertyName("pay_now_asset_urls_standard")]
        public string PayNowAssetUrlsStandard { get; set; }

        [JsonPropertyName("pay_now_name")]
        public string PayNowName { get; set; }

        [JsonPropertyName("pay_now_redirect_url")]
        public string PayNowRedirectUrl { get; set; }

        [JsonPropertyName("pay_over_time_asset_urls_descriptive")]
        public string PayOverTimeAssetUrlsDescriptive { get; set; }

        [JsonPropertyName("pay_over_time_asset_urls_standard")]
        public string PayOverTimeAssetUrlsStandard { get; set; }

        [JsonPropertyName("pay_over_time_name")]
        public string PayOverTimeName { get; set; }

        [JsonPropertyName("pay_over_time_redirect_url")]
        public string PayOverTimeRedirectUrl { get; set; }

        [JsonPropertyName("payment_method_categories")]
        public string PaymentMethodCategories { get; set; }

        [JsonPropertyName("purchase_country")]
        public string PurchaseCountry { get; set; }

        [JsonPropertyName("purchase_type")]
        public string PurchaseType { get; set; }

        [JsonPropertyName("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonPropertyName("shipping_delay")]
        public long ShippingDelay { get; set; }

        [JsonPropertyName("shipping_first_name")]
        public string ShippingFirstName { get; set; }

        [JsonPropertyName("shipping_last_name")]
        public string ShippingLastName { get; set; }
    }
}
