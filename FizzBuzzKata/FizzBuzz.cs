using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static int[] GetOneToOneHundred()
        {
            var intArray = new int[100];

            for (var i = 0; i < 100; i++)
            {
                intArray[i] = i+1;
            }

            return intArray;
        }
    }
}
