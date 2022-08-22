// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class PaymentIntentGetOptions : BaseOptions
    {
        [JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
