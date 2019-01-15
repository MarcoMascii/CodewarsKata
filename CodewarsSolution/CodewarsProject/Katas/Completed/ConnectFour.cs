using System.Collections.Generic;

namespace CodewarsProject.Katas
{
    public class ConnectFour
    {
        public static string WhoIsWinner(List<string> piecesPositionList)
        {
            char[,] grid = new char[7, 6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                    grid[j, i] = 'E';
            }

            foreach (string move in piecesPositionList)
            {
                string player = move.Split('_')[1];
                string winner = MakeMove(grid, move);
                if (!string.Equals(winner, "None"))
                    return winner;
            }
            return "Draw";
        }


        private static string MakeMove(char[,] grid, string move)
        {
            string player = move.Split('_')[1];
            string position = move.Split('_')[0];
            int column = position[0] - 65;
            int firstRowFree = FindFreeRow(grid, column);
            grid[column, firstRowFree] = player[0];
            return IsWinner(grid);
        }

        private static string IsWinner(char[,] grid)
        {
            string winner = "None";
            for (int i = 0; i < 7; i++)
            {
                winner = LineIsWinning(new string(new char[] { grid[i, 0], grid[i, 1], grid[i, 2], grid[i, 3], grid[i, 4], grid[i, 5] }));
                if (!string.Equals(winner, "None"))
                    return winner;
            }

            for (int i = 0; i < 6; i++)
            {
                winner = LineIsWinning(new string(new char[] { grid[0, i], grid[1, i], grid[2, i], grid[3, i], grid[4, i], grid[5, i], grid[6, i] }));
                if (!string.Equals(winner, "None"))
                    return winner;
            }

            foreach (string diagonal in GetDiagonals(grid))
            {
                winner = LineIsWinning(diagonal);
                if (!string.Equals(winner, "None"))
                    return winner;
            }

            return winner;
        }

        private static string LineIsWinning(string line)
        {
            if (line.Contains("RRRR"))
                return "Red";

            if (line.Contains("YYYY"))
                return "Yellow";

            return "None";
        }

        private static int FindFreeRow(char[,] grid, int column)
        {
            for (int i = 0; i < 6; i++)
            {
                if (grid[column, i] == 'E')
                    return i;
            }
            return 0;
        }

        private static List<string> GetDiagonals(char[,] grid)
        {
            List<string> diagonals = new List<string>();
            diagonals.Add(new string(new char[] { grid[0, 0], grid[1, 1], grid[2, 2], grid[3, 3], grid[4, 4], grid[5, 5] }));
            diagonals.Add(new string(new char[] { grid[1, 0], grid[2, 1], grid[3, 2], grid[4, 3], grid[5, 4], grid[6, 5] }));
            diagonals.Add(new string(new char[] { grid[2, 0], grid[3, 1], grid[4, 2], grid[5, 3], grid[6, 4] }));
            diagonals.Add(new string(new char[] { grid[3, 0], grid[4, 1], grid[5, 2], grid[6, 3] }));
            diagonals.Add(new string(new char[] { grid[0, 1], grid[1, 2], grid[2, 3], grid[3, 4], grid[4, 5] }));
            diagonals.Add(new string(new char[] { grid[0, 2], grid[1, 3], grid[2, 4], grid[3, 5] }));

            diagonals.Add(new string(new char[] { grid[6, 0], grid[5, 1], grid[4, 2], grid[3, 3], grid[2, 4], grid[1, 5] }));
            diagonals.Add(new string(new char[] { grid[5, 0], grid[4, 1], grid[3, 2], grid[2, 3], grid[1, 4], grid[0, 5] }));
            diagonals.Add(new string(new char[] { grid[4, 0], grid[3, 1], grid[2, 2], grid[1, 3], grid[0, 4] }));
            diagonals.Add(new string(new char[] { grid[3, 0], grid[2, 1], grid[1, 2], grid[0, 3] }));
            diagonals.Add(new string(new char[] { grid[6, 1], grid[5, 2], grid[4, 3], grid[3, 4], grid[2, 5] }));
            diagonals.Add(new string(new char[] { grid[6, 2], grid[5, 3], grid[4, 4], grid[3, 5] }));
            return diagonals;
        }
    }
}
