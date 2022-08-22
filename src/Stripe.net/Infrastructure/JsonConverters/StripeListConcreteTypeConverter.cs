namespace Stripe.Infrastructure
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
                Data = properties.Where(x => x.Key.Name == "Data").Select(x => x.Value).FirstOrDefault() as List<T>,
                HasMore = (bool)(properties.Where(x => x.Key.Name == "HasMore").Select(x => x.Value).FirstOrDefault() ?? false),
                Object = properties.Where(x => x.Key.Name == "Object").Select(x => x.Value).FirstOrDefault() as string,
                StripeResponse = properties.Where(x => x.Key.Name == "StripeResponse").Select(x => x.Value).FirstOrDefault() as StripeResponse,
                Url = properties.Where(x => x.Key.Name == "Url").Select(x => x.Value).FirstOrDefault() as string,
            };
        }

        public override void Write(Utf8JsonWriter writer, StripeList<T> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
