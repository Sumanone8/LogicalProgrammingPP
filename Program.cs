using System;

namespace LogicalPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problem Solver!");
            Console.WriteLine("Choose a problem to proceed:");
            Console.WriteLine("1.Fabonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse a Number\n5.Coupon Number\n6.Stimulated Stopwatch");
            Console.WriteLine("2.");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FabonacciSeries.Solve();
                    break;
                case 2:
                    PerfectNumber.Solve();
                    break;
                case 3:
                    PrimeNumber.Solve(); 
                    break;
                case 4:
                    ReverseNumber.Solve();
                    break;
                case 5:
                    CouponNumber.Solve();
                    break;
                case 6:
                    Stopwatch.Solve();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
