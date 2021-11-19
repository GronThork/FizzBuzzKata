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

        [Fact]
        public void ReturnFalseIfFourTeenIsNotMultipleOfThreeAndFive()
        {
            bool expected = false;

            bool actual = FizzBuzz.IsFizzAndBuzz(14);

            Assert.Equal(expected, actual);
        }
    }
}
