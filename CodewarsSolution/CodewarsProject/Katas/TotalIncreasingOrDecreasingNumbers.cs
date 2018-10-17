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

            int[,] decrease = new int[x, 10];
            int[,] increase = new int[x, 10];

            for (int k = 0; k < 9; k++)
            {
                decrease[0, k] = 1;
                increase[0, k] = 1;
            }

            
            for (int i = 1; i < x; i++)
            {
                for (int current = 0; current <= 9; current++)
                {
                    decrease[i, current] = 0;
                    for (int smaller = 0; smaller < current; smaller++)
                    {
                        decrease[i, current] = (decrease[i, current] + decrease[i - 1, smaller]);
                    }
                    increase[i, current] = 0;
                    for (int bigger = 0; bigger <= 9; bigger++)
                    {
                        increase[i, current] = (increase[i, current] + increase[i - 1, bigger]);
                    }
                }
                for (int k = 0; k < 9; k++)
                {
                    result += decrease[i, k] + increase[i, k];
                }

                result -= increase[i, 0];
                result -= 10;
            }

            result += 1;
            return result;
        }

        private BigInteger Factorial(BigInteger number, BigInteger start)
        {
            BigInteger result = BigInteger.One;
            for (BigInteger i = start; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
