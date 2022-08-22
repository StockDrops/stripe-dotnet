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
    using Stripe.Infrastructure.JsonConverters.Base;

    public class StripeSearchResultConverter<T> : SimpleConcreteTypeConverter<StripeSearchResult<T>>
        where T : class
    {
        public StripeSearchResultConverter()
            : base(GeneraterateList)
        {
        }

        public static StripeSearchResult<T> GeneraterateList(Dictionary<PropertyInfo, object> properties)
        {
            return new StripeSearchResult<T>()
            {
                Data = properties.Where(x => x.Key.Name == "Data").Select(x => x.Value).FirstOrDefault() as List<T>,
                HasMore = (bool)(properties.Where(x => x.Key.Name == "HasMore").Select(x => x.Value).FirstOrDefault() ?? false),
                Object = properties.Where(x => x.Key.Name == "Object").Select(x => x.Value).FirstOrDefault() as string,
                StripeResponse = properties.Where(x => x.Key.Name == "StripeResponse").Select(x => x.Value).FirstOrDefault() as StripeResponse,
                Url = properties.Where(x => x.Key.Name == "Url").Select(x => x.Value).FirstOrDefault() as string,
                NextPage = properties.Where(x => x.Key.Name == "NextPage").Select(x => x.Value).FirstOrDefault() as string,
                TotalCount = (long?)properties.Where(x => x.Key.Name == "TotalCount").Select(x => x.Value).FirstOrDefault(),
            };
        }

        public override void Write(Utf8JsonWriter writer, StripeSearchResult<T> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

    public class StripeSearchResultConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            if (typeToConvert.IsGenericType)
            {
                var genericArgument = typeToConvert.GetGenericArguments()[0];
                if (genericArgument.IsInterface)
                {
                    return false;
                }

                return typeof(StripeSearchResult<>).IsAssignableFrom(typeToConvert.GetGenericTypeDefinition());
            }

            return false;
        }

        public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            Type elementType = typeToConvert.GetGenericArguments()[0];

            Type typeToMake;

            typeToMake = typeof(StripeSearchResultConverter<>).MakeGenericType(elementType);

            JsonConverter converter = (JsonConverter)Activator.CreateInstance(typeToMake);

            return converter;
        }
    }
}
