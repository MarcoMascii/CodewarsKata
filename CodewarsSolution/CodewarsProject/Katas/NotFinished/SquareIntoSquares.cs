using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject.Katas
{
    public class Decompose
    {
        public string decompose(long n)
        {
            HashSet<long> decomposeArray = Decomposer(n, n * n);
            if (decomposeArray == null) return null;

            decomposeArray.Remove(decomposeArray.Last());
            List<String> result = new List<string>();

            foreach (long ele in decomposeArray)
            {
                result.Add(ele.ToString());
            }

            return string.Join(" ", result);
        }


        public HashSet<long> Decomposer(long n, long remain)
        {
            // basic case
            if (remain == 0)
            {
                HashSet<long> r = new HashSet<long>();
                r.Add(n);
                return r;
            }
            for (long i = n - 1; i > 0; i--)
            {
                if ((remain - i * i) >= 0)
                {
                    HashSet<long> r = Decomposer(i, (remain - i * i));
                    if (r != null)
                    {
                        r.Add(n);
                        return r;
                    }
                }
            }
            return null;
        }
    }
}
