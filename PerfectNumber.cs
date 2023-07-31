using System;

namespace LogicalPrograming
{
    public static class PerfectNumber
    {
        public static void Solve()
        {
            Console.WriteLine("Enter a number to check if it is a Perfect Number:");
            int number = int.Parse(Console.ReadLine());

            bool isPerfect = CheckPerfectNumber(number);

            if (isPerfect)
            {
                Console.WriteLine($"{number} is a Perfect Number.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT a Perfect Number.");
            }
        }

        private static bool CheckPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
}
