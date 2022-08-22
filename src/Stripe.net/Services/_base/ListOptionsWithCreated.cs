namespace Stripe
{
    using System;
    using System.Text.Json.Serialization;
    using Stripe.Infrastructure;

    public class ListOptionsWithCreated : ListOptions
    {
        /// <summary>
        /// A filter on the list based on the object <c>created</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonPropertyName("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }
    }
}
