namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json.Serialization;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This test checks that <see cref="Stripe.StripeEntity" /> subclasses that have a
    /// <c>Deleted</c> property have <see cref="Newtonsoft.Json.NullValueHandling" />
    /// set to <see cref="Newtonsoft.Json.NullValueHandling.Ignore" /> so that the property is not
    /// serialized when its value is <c>null</c>.
    /// </summary>
    public class DontSerializeNullDeletedAttrs : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one invalid Deleted property. Make sure that the property " +
            "has a JsonPropertyNameAttribute and that NullValueHandling is set to Ignore.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all StripeEntity subclasses
            var entityClasses = GetSubclassesOf(typeof(StripeEntity));

            foreach (Type entityClass in entityClasses)
            {
                foreach (PropertyInfo property in entityClass.GetProperties())
                {
                    if (property.Name != "Deleted")
                    {
                        continue;
                    }

                    // Check that property has a JsonPropertyNameAttribute
                    var attribute = property.GetCustomAttribute<JsonIgnoreAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    // Check that NullValueHanding is set to Ignore
                    if (attribute.Condition == JsonIgnoreCondition.WhenWritingNull)
                    {
                        continue;
                    }

                    results.Add($"{entityClass.Name}.{property.Name}");
                }
            }

            if (results.Any())
            {
                // Sort results alphabetically
                results = results.OrderBy(i => i).ToList();

                // Display our own error message (because Assert.Empty truncates the results)
                Console.WriteLine("Found invalid Deleted properties:");
                foreach (string item in results)
                {
                    Console.WriteLine($"- {item}");
                }

                // Actually fail test
                Assert.True(false, AssertionMessage);
            }
        }
    }
}
