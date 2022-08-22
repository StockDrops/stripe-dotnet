namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class PromotionCodeTest : BaseStripeTest
    {
        public PromotionCodeTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/promotion_codes/co_123");
            var promoCode = JsonSerializer.Deserialize<PromotionCode>(json);
            Assert.NotNull(promoCode);
            Assert.IsType<PromotionCode>(promoCode);
            Assert.NotNull(promoCode.Id);
            Assert.Equal("promotion_code", promoCode.Object);
        }

        [Fact]
        public void DeserializeWithExpansionsCustomer()
        {
            string[] expansions =
            {
              "customer",
            };

            string json = this.GetFixture("/v1/promotion_codes/co_123", expansions);
            var promoCode = JsonSerializer.Deserialize<PromotionCode>(json);
            Assert.NotNull(promoCode);
            Assert.IsType<PromotionCode>(promoCode);
            Assert.NotNull(promoCode.Id);
            Assert.Equal("promotion_code", promoCode.Object);

            Assert.NotNull(promoCode.Customer);
            Assert.IsType<Customer>(promoCode.Customer);
            Assert.Equal("customer", promoCode.Customer.Object);
        }
    }
}
