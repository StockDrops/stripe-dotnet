namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;

    public class StripeObjectConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.GetTypeInfo().IsInterface;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var typeToMake = typeof(StripeObjectConverter<>).MakeGenericType(typeToConvert);

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(typeToMake);

            return converter;
        }
    }
}
