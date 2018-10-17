using System;

namespace CodewarsProject
{
    public static class Immortal
    {
        public static long ElderAge(long n, long m, long k, long newp)
        {
            long longer = n > m ? n : m;
            long shorter = n < m ? n : m;
            long total = 0;
            //longer -= k;
            total = (longer - 1) * longer * shorter / 2;

            if (shorter != longer)
            {
                total += shorter * (shorter - 1) / 2;
            }
            
            //long total = (longer * (longer + 1) / 2) * shorter;
            //Console.WriteLine(total);

            return total % newp;
        }
    }
}
