using System.Numerics;

namespace CodewarsProject
{
    public class Fibonacci
    {

        public static BigInteger fib(BigInteger n)
        {
            BigInteger[,] result = { { BigInteger.One, BigInteger.One }, { BigInteger.One, BigInteger.Zero } };

            bool negated = false;

            switch (n.CompareTo(BigInteger.Zero))
            {
                case -1:
                    n = BigInteger.Negate(n);
                    negated = true;
                    break;
                case 0:
                    return BigInteger.Zero;
            }

            power(result, n - BigInteger.One);

            if (negated)
                return BigInteger.Equals(n % BigInteger.Parse("2"), BigInteger.One) ? result[0, 0] : BigInteger.Negate(result[0, 0]);
            return result[0, 0];
        }

        private static void power(BigInteger[,] array, BigInteger n)
        {
            if (n.Equals(BigInteger.Zero) || n.Equals(BigInteger.One))
                return;

            BigInteger[,] identity = { { BigInteger.One, BigInteger.One }, { BigInteger.One, BigInteger.Zero } };

            power(array, BigInteger.Divide(n, BigInteger.Parse("2")));
            multiply(array, array);
            if (!BigInteger.Equals(n % BigInteger.Parse("2"), BigInteger.Zero))
                multiply(array, identity);
        }

        private static void multiply(BigInteger[,] arr1, BigInteger[,] arr2)
        {
            BigInteger x = BigInteger.Add(BigInteger.Multiply(arr1[0, 0], arr2[0, 0]), BigInteger.Multiply(arr1[0, 1], arr2[1, 0]));
            BigInteger y = BigInteger.Add(BigInteger.Multiply(arr1[0, 0], arr2[0, 1]), BigInteger.Multiply(arr1[0, 1], arr2[1, 1]));
            BigInteger z = BigInteger.Add(BigInteger.Multiply(arr1[1, 0], arr2[0, 0]), BigInteger.Multiply(arr1[1, 1], arr2[1, 0]));
            BigInteger w = BigInteger.Add(BigInteger.Multiply(arr1[1, 0], arr2[0, 1]), BigInteger.Multiply(arr1[1, 1], arr2[1, 1]));
            arr1[0, 0] = x;
            arr1[0, 1] = y;
            arr1[1, 0] = z;
            arr1[1, 1] = w;
        }
    }
}
