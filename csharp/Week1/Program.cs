using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week 1 activity!");
        }
    }

    public class Digits
    {
        /// <summary>
        /// This function accepts an integer and returns the sum of all its digits
        /// </summary>
        /// <param name="n"> n > -1 ||</param>
        /// <returns></returns>
        public static int AddDigits(int n)
        {
            int sum = 0;

            char[] digits = n.ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++)
                sum += int.Parse(digits[i].ToString());

            return sum;
        }

        public static int LargestNumber(int n)
        {
            //// Solution 1
            ////string num = string.Empty;
            ////for (int i = 0; i < n; i++)
            ////    num += "9";

            ////return int.Parse(num);

            // Solution 2
            return (int) Math.Pow(10, n) - 1;
        }

        public static int OptimalEqualSplit(int n, int m)
        {
            return m - (m % n);
        }

        public static int Persistence(int n)
        {
            int persistenceCount = 0;

            if (n < 10)
                return persistenceCount;

            var digits = n.ToString().ToCharArray();

            double digitsProduct = 1;

            for (int i = 0; i < digits.Length; i++)
            {
                digitsProduct *= int.Parse(digits[i].ToString());
            }

            persistenceCount++;

            if (digitsProduct >= 10)
            {
                persistenceCount += Persistence((int)digitsProduct);
            }

            return persistenceCount;
        }
    }
}