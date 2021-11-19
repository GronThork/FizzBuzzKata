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

        public static bool IsFizzAndBuzz(int input)
        {
            if (IsFizz(input) && IsBuzz(input))
                return true;

            return false;
        }

        public static bool IsFizz(int input)
        {
            if (input % 3 == 0)
                return true;
            
            return false;
        }

        public static bool IsBuzz(int input)
        {
            if (input % 5 == 0)
                return true;

            return false;
        }
    }
}
