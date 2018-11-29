using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject
{
    public class SudokuSolver
    {
        public static string digits = "123456789";
        public static string rows = "ABCDEFGHI";
        public static string cols = digits;
        public static string[] squares = Cross(rows, cols);
        public static HashSet<HashSet<string>> _unitList = CreateUnitList();
        public static Dictionary<string, HashSet<HashSet<string>>> _units = CreateUnits();
        public static Dictionary<string, HashSet<string>> _peers = CreatePeers();

        static string[] Cross(string A, string B)
        {
            string[] result = new string[A.Length * B.Length];
            int counter = 0;
            foreach (char a in A)
            {
                foreach (char b in B)
                {
                    result[counter] = a.ToString() + b.ToString();
                    counter++;
                }
            }
            return result;
        }

        public static HashSet<HashSet<string>> CreateUnitList()
        {
            HashSet<HashSet<string>> unitList = new HashSet<HashSet<string>>();
            HashSet<string> singleUnit = new HashSet<string>();

            foreach (char c in cols)
            {
                singleUnit = new HashSet<string>(Cross(rows, c.ToString()));
                unitList.Add(singleUnit);
            }
            foreach (char r in rows)
            {
                singleUnit = new HashSet<string>(Cross(r.ToString(), cols).ToList());
                unitList.Add(singleUnit);
            }
            string[] rs = { "ABC", "DEF", "GHI" };
            string[] cs = { "123", "456", "789" };
            foreach (string boxr in rs)
            {
                foreach (string boxc in cs)
                {
                    singleUnit = new HashSet<string>(Cross(boxr, boxc).ToList());
                    unitList.Add(singleUnit);
                }
            }
            return unitList;
        }

        static Dictionary<string, HashSet<string>> CreatePeers()
        {
            Dictionary<string, HashSet<string>> peers = new Dictionary<string, HashSet<string>>();
            HashSet<string> peer = new HashSet<string>();
            foreach (string s in squares)
            {
                peer = new HashSet<string>(_units[s].SelectMany(x => x).Distinct());
                peer.Remove(s);
                peers.Add(s, peer);
            }
            return peers;
        }

        static Dictionary<string, HashSet<HashSet<string>>> CreateUnits()
        {
            Dictionary<string, HashSet<HashSet<string>>> union = new Dictionary<string, HashSet<HashSet<string>>>();
            HashSet<HashSet<string>> tempList = new HashSet<HashSet<string>>();
            foreach (string s in squares)
            {
                tempList = new HashSet<HashSet<string>>();
                foreach (HashSet<string> u in _unitList)
                {
                    if (u.Contains(s))
                    {
                        tempList.Add(u);
                    }
                }
                union.Add(s, tempList);
            }

            return union;
        }

        static Dictionary<string, string> FillValues()
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            foreach (string s in squares)
            {
                values.Add(s, digits);
            }

            return values;
        }

        static Dictionary<string, string> Eliminate(Dictionary<string, string> values, string s, string d)
        {
            if (!values[s].Contains(d))
                return values;

            values[s] = values[s].Replace(d, "");

            if (values[s].Length == 0)
                return null;

            if (values[s].Length == 1)
            {
                string d2 = values[s];
                foreach (string s2 in _peers[s])
                {
                    if (Eliminate(values, s2, d2) == null)
                        return null;
                }
            }

            foreach (HashSet<string> u in _units[s])
            {
                List<string> dplaced = new List<string>();
                foreach (string s2 in u)
                {
                    if (values[s2].Contains(d))
                        dplaced.Add(s2);
                }
                if (!dplaced.Any())
                {
                    return null;
                }
                if (dplaced.Count == 1)
                {
                    if (AssignValue(values, dplaced[0], d) == null)
                        return null;
                }
            }

            return values;
        }

        static Dictionary<string, string> AssignValue(Dictionary<string, string> values, string s, string d)
        {
            string remainingValues = values[s].Replace(d, "");

            foreach (char d2 in remainingValues)
            {
                if (Eliminate(values, s, d2.ToString()) == null)
                    return null;
            }
            return values;
        }


        public static Dictionary<string, string> Solve(string grid)
        {
            Dictionary<string, string> values = FillValues();
            Dictionary<string, string> gridValues = new Dictionary<string, string>();
            int iterator = 0;

            foreach (string square in squares)
            {
                gridValues.Add(square, grid[iterator].ToString());
                iterator++;
            }

            foreach (KeyValuePair<string, string> element in gridValues)
            {
                if (digits.Contains(element.Value) && AssignValue(values, element.Key, element.Value) == null)
                {
                    return null;
                }
            }
            return Search(values);
        }

        static Dictionary<string, string> Search(Dictionary<string, string> values)
        {
            Dictionary<string, string> valuesCopy = new Dictionary<string, string>();
            if (values == null)
            {
                return null;
            }

            bool isSolved = true;
            foreach (string square in squares)
            {
                isSolved &= values[square].Length == 1;
            }

            if (isSolved)
            {
                return values;
            }

            KeyValuePair<string, string> minUnfilled = new KeyValuePair<string, string>();

            minUnfilled = values.Aggregate((l, r) => l.Value.Length < r.Value.Length ? l : r);

            foreach (char d in values[minUnfilled.Key])
            {
                valuesCopy = values;
                Search(AssignValue(valuesCopy, minUnfilled.Key, d.ToString()));
            }

            return values;
        }

    }
}
