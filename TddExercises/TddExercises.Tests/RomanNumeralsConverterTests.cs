using FluentAssertions;
using Xunit;

namespace TddExercises.Tests
{
    //Red-Green-Refactor
    public class RomanNumeralsConverterTests
    {
        [InlineData(0, "")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [Theory]
        public void When_InputIsOne_Return_I(int input, string expected)
        {
            var result = new RomanNumeralsConverter().Convert(input);
            result.Should().Be(expected);
        }
    }
}
