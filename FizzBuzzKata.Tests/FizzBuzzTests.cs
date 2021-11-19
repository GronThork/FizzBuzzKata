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
    }
}
