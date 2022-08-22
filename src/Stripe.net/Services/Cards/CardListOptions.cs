namespace Stripe
{
    using System.Text.Json.Serialization;

    public class CardListOptions : ListOptions
    {
        [JsonPropertyName("object")]
        internal string Object => "card";
    }
}
