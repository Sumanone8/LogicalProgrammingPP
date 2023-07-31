using System;

namespace LogicalPrograming
{
    public static class PrimeNumber
    {
        public static void Solve()
        {
            Console.WriteLine("Enter a number to check if it is a Prime Number:");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = CheckPrimeNumber(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is a Prime Number.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a Prime Number.");
            }
        }

        private static bool CheckPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            // Check if the number is divisible by any integer from 2 to the square root of the number
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
