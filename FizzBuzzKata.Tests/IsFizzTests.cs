using Xunit;

namespace FizzBuzzKata.Tests
{
    public class IsFizzTests
    {
        [Fact]
        public void ReturnTrueForInputThree()
        {
            bool expected = true;

            var actual = FizzBuzz.IsFizz(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnTrueForInputSix()
        {
            bool expected = true;

            var actual = FizzBuzz.IsFizz(6);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnTrueForInputNine()
        {
            bool expected = true;

            var actual = FizzBuzz.IsFizz(9);

            Assert.Equal(expected, actual);
        }
    }
}
