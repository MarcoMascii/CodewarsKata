using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    internal class Combination
    {
        internal long Num;
        internal IEnumerable<Combination> Combinations;
    }
    public class IntegerPartitions
    {
        public static string Part(long n)
        {
            var combination = GetCombinations(n);
            List<long> products = new List<long>();

            foreach (var c in combination)
            {
                products.Add(c.Aggregate(1, (a, b) => (int)(a * b)));
            }
            products = products.Distinct().ToList();
            products.Sort();
            double median = products.Count() % 2 != 0 ? products[products.Count() / 2 ] : ((double)products[products.Count() / 2] + (double)products[(products.Count() / 2) - 1]) / 2.0;
            string output = string.Format("Range: {0} Average: {1} Median: {2}", products.Max() - products.Min(), products.Average().ToString("0.00"), median.ToString("0.00"));
            return output;
        }

        internal static IEnumerable<Combination> GetCombinationTrees(long num, long max)
        {
            return Enumerable.Range(1,(int)num)
                             .Where(n => n <= max)
                             .Select(n =>
                                 new Combination
                                 {
                                     Num = n,
                                     Combinations = GetCombinationTrees(num - n, n)
                                 });
        }

        internal static IEnumerable<IEnumerable<long>> BuildCombinations(
                                                       IEnumerable<Combination> combinations)
        {
            if (combinations.Count() == 0)
            {
                return new[] { new long[0] };
            }
            else
            {
                return combinations.SelectMany(c =>
                                      BuildCombinations(c.Combinations)
                                           .Select(l => new[] { c.Num }.Concat(l))
                                    );
            }
        }

        public static IEnumerable<IEnumerable<long>> GetCombinations(long num)
        {
            var combinationsList = GetCombinationTrees(num, num);

            return BuildCombinations(combinationsList);
        }
    }
}
