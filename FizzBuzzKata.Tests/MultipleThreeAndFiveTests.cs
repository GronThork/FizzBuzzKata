using Xunit;

namespace FizzBuzzKata.Tests
{
    public class MultipleThreeAndFiveTests
    {
        [Fact]
        public void ReturnFizzBuzzIfFifteenIsMultipleOfThreeAndFive()
        {
            string expected = "FizzBuzz";

            string actual = FizzBuzz.IsFizzAndBuzz(15);

            Assert.Equal(expected,actual);
        }
    }
}
