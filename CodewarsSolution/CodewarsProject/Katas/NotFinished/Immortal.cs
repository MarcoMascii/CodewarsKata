using System.IO;

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
            long temp = 0;
            //total = (longer - 1) * longer * shorter / 2;

            //using (StreamWriter writer = File.AppendText(@"C:\Users\Marco\Desktop\test.csv"))
            {

                for (long i = 0; i < n; i++)
                {
                    for (long j = 0; j < m; j++)
                    {
                        temp = (i ^ j) - k;
                        temp = temp > 0 ? temp : 0;
                        total += temp;
                        //writer.Write((temp) + ", ");
                    }
                    //writer.WriteLine();
                }
            }
            return total % newp;
        }
    }
}
