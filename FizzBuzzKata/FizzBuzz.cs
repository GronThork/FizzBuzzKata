using System;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public static string FizzBuzzMain(int v)
        {
            if (IsFizz(v) && IsBuzz(v))
                return "FizzBuzz";

            if (IsBuzz(v))
                return "Buzz";

            if (IsFizz(v))
                return "Fizz";

            return "PEPE";
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

        public static bool IsFizzAndBuzz(int input)
        {
            if (IsFizz(input) && IsBuzz(input))
                return true;

            return false;
        }
    }
}
