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
        public static Dictionary<string, string[]> peers = CreatePeers(rows, cols);
        public static string[] unitList = CreateUnitList();

        private static string[] Cross(string A, string B)
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

        private static string[] CreateUnitList()
        {
            string[][] temppp = new string[27][];
            List<string> temp = new List<string>();
            foreach (char c in cols)
            {
                temp.AddRange(Cross(rows, c.ToString()).ToList());
            }
            foreach (char r in rows)
            {
                temp.AddRange(Cross(r.ToString(), cols).ToList());
            }
            string[] rs = { "ABC", "DEF", "GHI" };
            string[] cs = { "123", "456", "789" };
            foreach (string boxr in rs)
            {
                foreach (string boxc in cs)
                {
                        temp.AddRange(Cross(boxr, boxc).ToList());
                }
            }
            return temp.ToArray();
        }

        private static Dictionary<string, string[]> CreatePeers(string rows, string col)
        {
            Dictionary<string, string[]> peers = new Dictionary<string, string[]>();
            foreach (char a in rows)
            {
                foreach (char b in col)
                {
                    List<string> temp = new List<string>(Cross(a.ToString(), col).Union(Cross(rows, b.ToString())));
                    temp.Remove(a.ToString() + b.ToString());
                    peers.Add(a.ToString() + b.ToString(), temp.ToArray());
                }
            }
            return peers;
        }
        

        private static Dictionary<string, string[][]> CreateUnions(string rows, string col)
        {
            Dictionary<string, string[][]> union = new Dictionary<string, string[][]>();

            foreach (string s in squares)
            {
                foreach (string u in unitList)
                {
                    if (u.Contains(s))
                    {
                        //union.Add(s, u);
                    }
                }
            }

            return union;
        }
    }
}
