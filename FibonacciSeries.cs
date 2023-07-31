using System;

namespace LogicalPrograming
{
    public static class FabonacciSeries
    {
        public static void Solve()
        {
            Console.WriteLine("Enter the number of terms for Fibonacci series:");
            int numTerms = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci series:");
            GenerateFibonacciSeries(numTerms);
        }

        private static void GenerateFibonacciSeries(int numTerms)
        {
            int firstTerm = 0;
            int secondTerm = 1;

            for (int i = 0; i < numTerms; i++)
            {
                Console.Write($"{firstTerm} ");

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.WriteLine();
        }
    }
}
