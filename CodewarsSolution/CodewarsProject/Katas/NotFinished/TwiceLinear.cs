using System;
using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    public class TwiceLinear
    {
        public static int DblLinear(int n)
        {
            HashSet<int> finalList = new HashSet<int> { 1 };
            int total = 1;
            int item = 1;
            int temp;
            while (total <= n)
            {
                item++;
                if ((item -1) %2 ==0)
                {
                    temp = (item - 1) / 2;
                    if (finalList.Contains(temp))
                    {
                        finalList.Add(item);
                        total++;
                        continue;
                    }
                }
                if ((item - 1) % 3 == 0)
                {
                    temp = (item - 1) / 3;
                    if (finalList.Contains(temp))
                    {
                        finalList.Add(item);
                        total++;
                        continue;
                    }
                }
            }
            return item;
        }
    }
}
