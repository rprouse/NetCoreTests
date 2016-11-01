using Utilities;
using Xunit;

namespace XUnit.Test.One
{
    public enum TestTypes
    {
        none = 0,
        a,
        B,
        Testing,
        UnitTesting,
        integrationTesting
    }

    [Trait("Category", "xUnit")]
    public class EnumToStringConverterTests
    {
        [Theory]
        [InlineData((TestTypes)10, "")]
        [InlineData(TestTypes.a, "A")]
        [InlineData(TestTypes.B, "B")]
        [InlineData(TestTypes.none, "None")]
        [InlineData(TestTypes.Testing, "Testing")]
        [InlineData(TestTypes.UnitTesting, "Unit Testing")]
        [InlineData(TestTypes.integrationTesting, "Integration Testing")]
        public void CanConvertEnumIntoFriendlyString(TestTypes value, string expected)
        {
            // Arrange/Act
            var actual = value.ToFriendlyString();

            // Assert
            Assert.NotNull(actual);
            Assert.Equal(expected, actual);
        }
    }
}
