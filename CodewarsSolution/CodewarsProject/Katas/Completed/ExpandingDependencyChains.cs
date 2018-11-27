using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    public class ExpandingDependencyChains
    {
        public static Dictionary<string, string[]> ExpandDependencies(Dictionary<string, string[]> dependencies)
        {
            Dictionary<string, string[]> result = new Dictionary<string, string[]>();

            foreach (var item in dependencies)
            {
                result.Add(item.Key, AddDependencies(item.Value, dependencies));
            }

            foreach (var item in result)
            {
                if (item.Value.Contains(item.Key))
                {
                    throw new System.InvalidOperationException();
                }
            }
            return result;
        }

        private static string[] AddDependencies(string[] dependenciesIHave, Dictionary<string, string[]> dependencies)
        {
            List<string> temp = dependenciesIHave.ToList();

            for (int i = 0; i < dependenciesIHave.Count(); i++)
            {
                temp.AddRange(dependencies[dependenciesIHave[i]]);
            }

            temp = temp.Distinct().ToList();

            if (temp.Any(x=> !dependenciesIHave.Contains(x)))
            {
                dependenciesIHave = AddDependencies(temp.ToArray(), dependencies);
            }

            return dependenciesIHave;
        }
    }
}
