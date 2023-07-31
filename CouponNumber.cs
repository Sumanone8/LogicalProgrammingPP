using System;

namespace LogicalPrograming
{
    public static class CouponNumber
    {
        public static void Solve()
        {
            Console.WriteLine("Enter the number of distinct coupon numbers:");
            int n = int.Parse(Console.ReadLine());

            int totalRandomNumbersNeeded = GenerateDistinctCoupons(n);

            Console.WriteLine($"Total random numbers needed to have all distinct coupons: {totalRandomNumbersNeeded}");
        }

        private static int GenerateDistinctCoupons(int n)
        {
            Random random = new Random();
            bool[] coupons = new bool[n];
            int distinctCount = 0;
            int totalCount = 0;

            while (distinctCount < n)
            {
                int randomCoupon = random.Next(0, n);

                if (!coupons[randomCoupon])
                {
                    coupons[randomCoupon] = true;
                    distinctCount++;
                }

                totalCount++;
            }

            return totalCount;
        }
    }
}
