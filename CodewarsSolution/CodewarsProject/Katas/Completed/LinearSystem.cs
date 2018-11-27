using System;

namespace CodewarsProject
{
    public class LinearSystem
    {
        public string Solve(string input)
        {
            input = input.Replace(Environment.NewLine, "|");
            string[] lines = input.Split('|');
            int n = lines[0].Split(' ').Length - 1;
            int[] toIntArray = new int[n];
            int[,] matrix = new int[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    matrix[i, j] = int.Parse(lines[i].Split(' ')[j]);
                }
            }

            var test = matrix;
            GaussAlgorithm(matrix, n);
            string result = "";
            return result;
        }

        private int[] GaussAlgorithm(int[,] matrix, int n)
        {
            int h = 0;
            int k = 0;
            double max = 0;
            int i_max = 0;
            while (h < n + 1 && k < n)
            {
                max = 0;
                i_max = 0;
                for (int i = 0; i < n + 1; n++)
                {
                    if (Math.Abs(matrix[i, k]) > max)
                    {
                        max = Math.Abs(matrix[i, k]);
                        i_max = i;
                    }
                }
                if (i_max == 0)
                {
                    k++;
                }
                else
                {

                }
            }


            return null;
        }
    }
}
