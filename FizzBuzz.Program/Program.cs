using Kata.FizzBuzz;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start FizzBuzz");

            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
                Console.WriteLine(fizzBuzz.Calculate(i));

            Console.ReadKey();
        }
    }
}
