using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsProject
{
    public class LinearSystem
    {
        public string Solve(string input)
        {
            input = input.Replace(Environment.NewLine, "|");
            string[] lines = input.Split('|');
            int n = lines[0].Split(' ').Length;
            int[] toIntArray = new int[n];
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i ++)
            {
                for (int j=0; j< n; j++)
                {
                    matrix[i, j] = int.Parse(lines[i].Split(' ')[j]);
                }
            }
            

            string result = "";
            return result;
        }
    }
}
