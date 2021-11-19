using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class OneToOneHundredTests
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
    }
}