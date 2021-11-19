using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ReturnsOneInPositionZero()
        {
            int expected = 1;

            int actual = FizzBuzz.GetOneToOneHundred()[0];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsTwoInPositionOne()
        {
            int expected = 2;

            int actual = FizzBuzz.GetOneToOneHundred()[1];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnsThreeInPositionTwo()
        {
            int expected = 3;

            int actual = FizzBuzz.GetOneToOneHundred()[2];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFizzForInputThree()
        {
            string expected = "Fizz";

            var actual = FizzBuzz.GetFizzBuzz(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFizzForInputSix()
        {
            string expected = "Fizz";

            var actual = FizzBuzz.GetFizzBuzz(6);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFizzForInputNine()
        {
            string expected = "Fizz";

            var actual = FizzBuzz.GetFizzBuzz(9);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBuzzForInputFive()
        {
            string expected = "Buzz";

            var actual = FizzBuzz.GetFizzBuzz(5);

            Assert.Equal(expected, actual);
        }

    }
}
