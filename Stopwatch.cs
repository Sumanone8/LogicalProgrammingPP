using System;

namespace LogicalPrograming
{
    public static class Stopwatch
    {
        public static void Solve()
        {
            Console.WriteLine("Press any key to start the stopwatch.");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press any key to stop the stopwatch.");
            Console.ReadKey();

            DateTime endTime = DateTime.Now;

            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine($"Elapsed time: {elapsedTime}");
        }
    }
}
