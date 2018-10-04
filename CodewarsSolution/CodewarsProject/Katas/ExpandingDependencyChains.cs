using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject
{
    public class ExpandingDependencyChains
    {
        public static Dictionary<string, string[]> ExpandDependencies(Dictionary<string, string[]> dependencies)
        {
            Dictionary<string, string[]> result = new Dictionary<string, string[]>();
            List<string> singleDep = new List<string>();
            List<string> outDep = new List<string>();

            foreach (KeyValuePair<string, string[]> file in dependencies)
            {
                singleDep = file.Value.ToList();
                outDep = singleDep;
                KeyValuePair<string, string[]> test = file;

                while (singleDep.Count > 0)
                {
                    foreach (string dep in dependencies[singleDep[0]])
                    {
                        if (!singleDep.Contains(dep))
                        {
                            singleDep.Add(dep);
                        }
                    }

                    
                }
            }

            return result;
        }
    }
}
