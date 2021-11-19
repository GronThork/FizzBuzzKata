
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
    }
}
