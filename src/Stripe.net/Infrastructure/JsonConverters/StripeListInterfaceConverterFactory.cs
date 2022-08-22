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

    public class StripeListInterfaceConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert.IsGenericType)
            {
                var genericArgument = typeToConvert.GetGenericArguments()[0];
                if (genericArgument.IsInterface)
                {
                    return typeof(StripeList<>).IsAssignableFrom(typeToConvert.GetGenericTypeDefinition());
                }
                return false;
            }

            return false;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            Type elementType = typeToConvert.GetGenericArguments()[0];

            var typeToMake = typeof(StripeListInterfaceConverter<>).MakeGenericType(elementType);

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(typeToMake);

            return converter;
        }
    }
}
