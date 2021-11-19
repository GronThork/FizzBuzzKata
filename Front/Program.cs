using FizzBuzzKata;
using System;

namespace Front
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(FizzBuzz.FizzBuzzMain(i + 1));
            }
        }
    }
}