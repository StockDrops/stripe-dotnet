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

    public class AnyOfConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(typeToConvert.GetTypeInfo());
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var genericConverter = typeof(AnyOfConverter<>).MakeGenericType(typeToConvert);
            return (JsonConverter)Activator.CreateInstance(genericConverter);
        }
    }
}
