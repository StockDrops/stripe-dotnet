namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    public class HasId : IHasId
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
