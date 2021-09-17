public class Digits {
  
        public static int AddDigits(int n)
        {
            int sum = 0;

            char[] digits = String.valueOf(n).toCharArray();

            for (int i = 0; i < digits.length; i++)
                sum += Integer.parseInt(String.valueOf(digits[i]));

            return sum;
        }

        public static int LargestNumber(int n)
        { 
            //Solution 1
            String num="";
            for (int i = 0; i < n; i++)
               num += "9";

            return Integer.parseInt(num);

            // // Solution 2
            // return (int) Math.pow(10, n) - 1;
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

            var digits = String.valueOf(n).toCharArray();

            double digitsProduct = 1;

            for (int i = 0; i < digits.length; i++)
            {
                digitsProduct *= Integer.parseInt(String.valueOf(digits[i]));
            }

            persistenceCount++;

            if (digitsProduct >= 10)
            {
                persistenceCount += Persistence((int)digitsProduct);
            }

            return persistenceCount;
        }
}
