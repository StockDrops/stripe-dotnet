namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class SubscriptionItemTest : BaseStripeTest
    {
        public SubscriptionItemTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/subscription_items/si_123");
            var subscriptionItem = JsonSerializer.Deserialize<SubscriptionItem>(json);
            Assert.NotNull(subscriptionItem);
            Assert.IsType<SubscriptionItem>(subscriptionItem);
            Assert.NotNull(subscriptionItem.Id);
            Assert.Equal("subscription_item", subscriptionItem.Object);
        }
    }
}
