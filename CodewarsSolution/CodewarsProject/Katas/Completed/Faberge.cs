using System.Numerics;

namespace CodewarsProject
{
    public class Faberge
    {
        public static BigInteger Height(BigInteger n, BigInteger m)
        {

            if (BigInteger.Compare(n, BigInteger.Zero) == 0 || BigInteger.Compare(m, BigInteger.Zero) == 0)
                return BigInteger.Zero;            

            BigInteger result = 1;
            BigInteger total = 0;

            BigInteger value = 1;
            for (BigInteger k = 1; k <= n; k++)
            {
                value = value * (m - k + 1) / k;
                total += value;
            }

            return total;
        }
    }
}
