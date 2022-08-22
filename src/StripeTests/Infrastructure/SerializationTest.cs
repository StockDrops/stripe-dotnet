namespace StripeTests
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class SerializationTest : BaseStripeTest
    {
        [Fact]
        public void RoundtripDatetime()
        {
            var date = DateTime.UtcNow;
            var roundedDate = date.AddTicks(-1 * (date.Ticks % TimeSpan.TicksPerSecond));
            var obj = new TestObjectDateTime
            {
                Date = roundedDate,
            };

            var reloaded = JsonSerializer.Deserialize<TestObjectDateTime>(JsonSerializer.Serialize(obj));
            Assert.Equal(reloaded.Date, obj.Date);
        }

        [Fact]
        public void HandleNull()
        {
            var obj = new TestObjectDateTime
            {
                Date = null,
            };

            var reloaded = JsonSerializer.Deserialize<TestObjectDateTime>(JsonSerializer.Serialize(obj));
            Assert.Null(reloaded.Date);
        }

        [Fact]
        public void Serialize()
        {
            var json = GetResourceAsString("api_fixtures.events.customer_updated.json");
            var evt = JsonSerializer.Deserialize<Event>(json);
            var serialized = JsonSerializer.Serialize(evt, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            var reserialized = JsonSerializer.Serialize(
                JsonSerializer.Deserialize<Event>(serialized), new JsonSerializerOptions
                {
                    WriteIndented = true,
                });
            Assert.Equal(serialized, reserialized);
        }
    }
}
