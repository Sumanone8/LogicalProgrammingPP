using System;

namespace LogicalPrograming
{
    public static class ReverseNumber
    {
        public static void Solve()
        {
            Console.WriteLine("Enter a number to reverse:");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = ReverseNumber1(number);

            Console.WriteLine($"Reversed number: {reversedNumber}");
        }

        private static int ReverseNumber1(int number)
        {
            int reversed = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversed = reversed * 10 + remainder;
                number /= 10;
            }

            return reversed;
        }
    }
}
