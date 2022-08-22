namespace Stripe.Infrastructure.JsonConverters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class StripeEntityConverterFactory : JsonConverterFactory
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///     <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return typeof(StripeEntity).IsAssignableFrom(objectType);
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var typeToMake = typeof(StripeEntityConverter<>).MakeGenericType(typeToConvert);

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(typeToMake);

            return converter;
        }
    }
}
