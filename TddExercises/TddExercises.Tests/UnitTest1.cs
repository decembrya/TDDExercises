using FluentAssertions;
using Xunit;

namespace TddExercises.Tests
{
    //Red-Green-Refactor
   
    public class UnitTest1
    {
        [Fact]
        public void When_InputIsOne_Return_I()
        {
            var input = 1;

            var result = new RomanNumeralsConverter().Convert(input);

            result.Should().Be("I");
        }
        
        [Fact]
        public void When_InputIsTwo_Return_II()
        {
            var input = 2;

            var result = new RomanNumeralsConverter().Convert(input);

            result.Should().Be("II");
        }
    }
}
