using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject
{
    public class Skyscrapers
    {
        static string digits = "1234";
        static string rows = "ABCD";
        static string cols = digits;
        static string[] square = Cross(rows, cols);

        static Dictionary<string, string[][]> units = new Dictionary<string, string[][]>();
        static Dictionary<string, string[]> peers = CreatePeers(rows, cols);

        public static int[][] SolvePuzzle(int[] clues)
        {
            Dictionary<string, string> values = new Dictionary<string, string>() { { "A1", "1234" }, { "A2", "1234" }, { "A3", "1234" }, { "A4", "1234" },
                                                                                   { "B1", "1234" }, { "B2", "1234" }, { "B3", "1234" }, { "B4", "1234" },
                                                                                   { "C1", "1234" }, { "C2", "1234" }, { "C3", "1234" }, { "C4", "1234" },
                                                                                   { "D1", "1234" }, { "D2", "1234" }, { "D3", "1234" }, { "D4", "1234" }};




            return null;
        }

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
            foreach (char a in rows)
            {
                foreach (char b in col)
                {
                    //string[] row
                    List<string> temp = new List<string>(Cross(a.ToString(), col).Union(Cross(rows, b.ToString())));
                    temp.Remove(a.ToString() + b.ToString());
                    //union.Add(a.ToString() + b.ToString(), temp.ToArray());
                }
            }
            return union;
        }

        private static Dictionary<string, string> Eliminate(Dictionary<string, string> values, string chosenCell, char valueToBeRemoved)
        {
            if (!values[chosenCell].Contains(valueToBeRemoved))
            {
                return values;
            }
            values[chosenCell] = values[chosenCell].Replace(valueToBeRemoved.ToString(), "");
            if (values[chosenCell].Length == 0)
            {
                return null;
            }
            else if (values[chosenCell].Length == 1)
            {
                int d2 = int.Parse(values[chosenCell]);
                //foreach ()
                {

                }

            }

            return values;
        }

    }
}
