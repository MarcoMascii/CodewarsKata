using System.Numerics;

namespace CodewarsProject
{
    public class Faberge
    {
        public static BigInteger Height(int n, int m)
        {
            if (n == 0 || m == 0)
            {
                return BigInteger.Zero;
            }

            BigInteger myNumber = BigInteger.One;

            //myNumber = (m * (m + 1)) / 2;

            while (n >= 2)
            {
                double temp = (double)((double)m * (m + 1.0)) / (double)Factorial(n);
                myNumber *= temp > 0 ? (BigInteger)temp : 1;
                m--;
                n--;
            }

            return myNumber-1;
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger result = BigInteger.One;
            while (n > 1)
            {
                result *= n;
                n--;
            }
            return result;
        }
    }
}
