using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    public class SumOfDivided
    {
        public static string sumOfDivided(int[] lst)
        {
            string result = "";
            List<int> primeNumbers = new List<int>();
            int number = 0;
            for (int i = 0; i < lst.Length; i++)
            {
                number = lst[i];
                if (number < 0)
                {
                    number = -1 * number;
                }
                for (int b = 2; number > 1; b++)
                    if (number % b == 0)
                    {
                        while (number % b == 0)
                        {
                            primeNumbers.Add(b);
                            number /= b;
                        }
                    }
            }
            primeNumbers = primeNumbers.Distinct().ToList();
            primeNumbers.Sort();
            int total = 0;

            foreach (int factor in primeNumbers)
            {

                total = 0;
                for (int i = 0; i < lst.Length; i++)
                {
                    if (lst[i] % factor == 0)
                    {
                        total += lst[i];
                    }
                }

                result = string.Concat(result, string.Format("({0} {1})", factor, total));
            }
            return result;
        }
    }
}
