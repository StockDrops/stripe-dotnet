namespace Stripe.Infrastructure.JsonConverters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using System.Text.Json.Serialization.Metadata;
    using Stripe.Infrastructure.JsonConverters.Base;

    public class StripeListConcreteTypeConverter<T> : SimpleConcreteTypeConverter<StripeList<T>>
        where T : class
    {
        public StripeListConcreteTypeConverter()
            : base(GeneraterateList)
        {
        }

        public static StripeList<T> GeneraterateList(Dictionary<PropertyInfo, object> properties)
        {
            return new StripeList<T>()
            {
                Data = properties.FirstOrDefault(p => p.Key.Name == "Data").Value as List<T>,
                HasMore = (bool)properties.FirstOrDefault(p => p.Key.Name == "HasMore").Value,
                Object = properties.FirstOrDefault(p => p.Key.Name == "Object").Value as string,
                StripeResponse = properties.FirstOrDefault(p => p.Key.Name == "StripeResponse").Value as StripeResponse,
                Url = properties.FirstOrDefault(p => p.Key.Name == "Url").Value as string,
            };
        }

        public override void Write(Utf8JsonWriter writer, StripeList<T> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
