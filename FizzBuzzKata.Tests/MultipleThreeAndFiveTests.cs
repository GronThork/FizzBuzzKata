using Xunit;

namespace FizzBuzzKata.Tests
{
    public class MultipleThreeAndFiveTests
    {
        [Fact]
        public void ReturnTrueIfFifteenIsMultipleOfThreeAndFive()
        {
            bool expected = true;

            bool actual = FizzBuzz.IsFizzAndBuzz(15);

            Assert.Equal(expected,actual);
        }
    }
}
