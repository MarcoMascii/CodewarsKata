using System;

namespace CodewarsProject
{
    public static class Immortal
    {
        public static long counter = 0;
        public static long ElderAge(long n, long m, long k, long newp)
        {
            long longer = n > m ? n : m;
            long shorter = n < m ? n : m;
            long total = 0;
            //longer -= k;
            long temp = 0;
            k = 0;
            //n = m;
            long counter = 0;
            //total = (longer - 1) * longer * shorter / 2;

            //using (StreamWriter writer = File.AppendText(@"C:\Users\Marco\Desktop\test.csv"))
            {

                for (long i = 0; i < n; i++)
                {
                    for (long j = 0; j < n; j++)
                    {
                        temp = (i ^ j) - k;
                        if ((temp & 9) == 9)
                        {
                            counter++;
                        }
                        total += temp > 0 ? temp : 0;
                    }
                }
            }
            Console.WriteLine(counter);
            return total % newp;
        }
    }
}
