using System;
using System.Collections.Generic;

namespace CallStack
{
    public class Primes
    {
        static void Main()
        {
            string[] numbersAsString = { "5", "16", "33", "10" };

            int[] numbers = ParseStringCollection(numbersAsString);
            PrintPrimes(numbers);
        }

        static void PrintPrimes(int[] numbers)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isPrime = IsPrime(numbers[i]);
                if (isPrime)
                {
                    primes.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", primes));
        }

        static bool IsPrime(int num)
        {
            int sqrt = (int) Math.Sqrt(num);
            for (int i = 2; i < sqrt; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


        static int[] ParseStringCollection(string[] strings)
        {
            int[] numbers = new int[strings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(strings[i]);
            }

            return numbers;
        }
    }
}
