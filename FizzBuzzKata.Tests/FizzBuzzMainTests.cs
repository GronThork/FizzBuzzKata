
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzMainTests
    {
        [Fact]
        public void FizzBuzzMain_ReturnBuzzForInputFive()
        {
            string expected = "Buzz";

            var actual = FizzBuzz.FizzBuzzMain(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzzMain_ReturnFizzForInputThree()
        {
            string expected = "Fizz";

            var actual = FizzBuzz.FizzBuzzMain(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzzMain_ReturnFizzBuzzForInputFifteen()
        {
            string expected = "FizzBuzz";

            var actual = FizzBuzz.FizzBuzzMain(15);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzzMain_ReturnInputForInputTwo()
        {
            string expected = "2";

            var actual = FizzBuzz.FizzBuzzMain(2);

            Assert.Equal(expected, actual);
        }
    }
}
