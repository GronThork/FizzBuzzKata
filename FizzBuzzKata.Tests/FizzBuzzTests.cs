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

            var actual = FizzBuzz.IsFizz(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFizzForInputSix()
        {
            string expected = "Fizz";

            var actual = FizzBuzz.IsFizz(6);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnFizzForInputNine()
        {
            string expected = "Fizz";

            var actual = FizzBuzz.IsFizz(9);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBuzzForInputFive()
        {
            string expected = "Buzz";

            var actual = FizzBuzz.IsBuzz(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBuzzForInputTen()
        {
            string expected = "Buzz";

            var actual = FizzBuzz.IsBuzz(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReturnBuzzForInputFifteen()
        {
            string expected = "Buzz";

            var actual = FizzBuzz.IsBuzz(15);

            Assert.Equal(expected, actual);
        }

    }
}
