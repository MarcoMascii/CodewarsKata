using System;

namespace CodewarsProject
{
    public class Magnets
    {
        public static double Doubles(int maxk, int maxn)
        {
            double result = 0;
            for (long k = 1; k <= maxk; k++)
            {
                for (long n = 1; n <= maxn; n++)
                {
                    result += 1.0 / (k * Math.Pow((double)(n + 1), 2 * k));
                }
            }
            return result;
        }
    }
}
