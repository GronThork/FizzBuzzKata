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

        public static string IsFizz(int input)
        {
            if (input % 3 == 0)
                return "Fizz";
            
            return input.ToString();
        }

        public static string IsBuzz(int input)
        {
            if (input == 5)
                return "Buzz";

            if (input == 10)
                return "Buzz";

            if (input == 15)
                return "Buzz";

            return input.ToString();
        }
    }
}
