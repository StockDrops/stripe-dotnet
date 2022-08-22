// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Text.Json.Serialization;

    public class SubscriptionItemListOptions : ListOptions
    {
        [JsonPropertyName("subscription")]
        public string Subscription { get; set; }
    }
}
