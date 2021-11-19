using Xunit;

namespace FizzBuzzKata.Tests
{
    public class IsBuzzTests
    {
        [Fact]
        public void ReturnTrueForInputFive()
        {
            bool expected = true;

            var actual = FizzBuzz.IsBuzz(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBuzzForInputTen()
        {
            bool expected = true;

            var actual = FizzBuzz.IsBuzz(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBuzzForInputFifteen()
        {
            bool expected = true;

            var actual = FizzBuzz.IsBuzz(15);

            Assert.Equal(expected, actual);
        }
    }
}
