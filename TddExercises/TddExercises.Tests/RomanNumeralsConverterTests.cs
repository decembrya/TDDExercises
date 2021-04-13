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
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [Theory]
        public void When_InputIsOne_Return_I(int input, string expected)
        {
            var result = new RomanNumeralsConverter().Convert(input);
            result.Should().Be(expected);
        }
    }
}
