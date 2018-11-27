using System.Numerics;

namespace CodewarsProject
{
    public class TotalIncreasingOrDecreasingNumbers
    {
        public static BigInteger TotalIncDec(int x)
        {
            BigInteger result = 1;
            BigInteger temp = BigInteger.One;

            for (int i = 1; i <= 10; i++)
            {
                temp *= (x + i);
            }

            temp /= 3628800;
            result += temp;
            temp = 1;

            for (int i = 1; i <= 9; i++)
            {
                temp *= (x + i);
            }

            temp /= 362880;
            result += temp - 2 - 10 * x;

            return result;
        }
    }
}
