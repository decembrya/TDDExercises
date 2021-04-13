using FluentAssertions;
using Xunit;

namespace TddExercises.Tests
{
    //Red-Green-Refactor
   
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var input = 1;

            var result = new RomanNumeralsConverter().Convert(input);

            result.Should().Be("I");
        }
    }
}
