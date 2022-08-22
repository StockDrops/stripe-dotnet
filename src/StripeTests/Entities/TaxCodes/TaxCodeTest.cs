namespace StripeTests
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    public class TaxCodeTest : BaseStripeTest
    {
        public TaxCodeTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/tax_codes/txcd_123");
            var taxCode = JsonSerializer.Deserialize<TaxCode>(json);
            Assert.NotNull(taxCode);
            Assert.IsType<TaxCode>(taxCode);
            Assert.NotNull(taxCode.Id);
            Assert.Equal("tax_code", taxCode.Object);
        }
    }
}
