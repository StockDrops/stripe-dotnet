namespace Stripe
{
    using System.Text.Json.Serialization;

    public class ChargeSourceListOptions : INestedOptions, IHasObject
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }
    }
}
