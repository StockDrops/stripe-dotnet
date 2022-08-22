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

    public class StripeListInterfaceConverter<TItem> : JsonConverter<StripeList<TItem>>
    {
        public override StripeList<TItem> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException("Couldn't read start of object");
            }

            if (!typeof(IBaseStripeList).GetTypeInfo().IsAssignableFrom(typeToConvert.GetTypeInfo()))
            {
                throw new JsonException("Cannot convert a list that is not assignable from IBaseStripeList");
            }

            var objectConverter = new StripeObjectConverter<TItem>();

            options = new JsonSerializerOptions();
            options.Converters.Add(objectConverter);

            var cloneReader = reader;
            var finalList = new StripeList<TItem>();

            while (cloneReader.Read())
            {
                if (cloneReader.TokenType == JsonTokenType.PropertyName && cloneReader.GetString() == "data")
                {
                    cloneReader.Read();
                    finalList.Data = JsonSerializer.Deserialize<List<TItem>>(ref cloneReader, options);
                    break;
                }
            }

            var list = JsonSerializer.Deserialize<BaseStripeList>(ref reader, options);

            finalList.HasMore = list.HasMore;
            finalList.Object = list.Object;
            finalList.Url = list.Url;

            return finalList;
        }

        public override void Write(Utf8JsonWriter writer, StripeList<TItem> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
