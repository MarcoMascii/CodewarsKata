using System.Collections.Generic;
using System.Linq;

namespace CodewarsProject.Katas
{
    public class TTTSolver
    {
        public class Move
        {
            public int Index { get; set; }
            public int Score { get; set; }
        }

        public static int[] TurnMethod(int[][] board, int player)
        {
            int[] boardArray = Enumerable.Range(0, 9).ToArray();
            int iterator = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i][j] != 0)
                        boardArray[iterator] = board[i][j];
                    iterator++;
                }
            }

            return ParseIndexToCoordinates(MiniMax(boardArray, player).Index);
        }

        public static bool Winning(int[] board, int player)
        {
            if ((board[0] == player && board[1] == player && board[2] == player) ||
                (board[3] == player && board[4] == player && board[5] == player) ||
                (board[6] == player && board[7] == player && board[8] == player) ||
                (board[0] == player && board[3] == player && board[6] == player) ||
                (board[1] == player && board[4] == player && board[7] == player) ||
                (board[2] == player && board[5] == player && board[8] == player) ||
                (board[0] == player && board[4] == player && board[8] == player) ||
                (board[2] == player && board[4] == player && board[6] == player))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int[] ParseIndexToCoordinates(int index)
        {
            switch (index)
            {
                case 0:
                    return new int[] { 0, 0 };
                case 1:
                    return new int[] { 0, 1 };
                case 2:
                    return new int[] { 0, 2 };
                case 3:
                    return new int[] { 1, 0 };
                case 4:
                    return new int[] { 1, 1 };
                case 5:
                    return new int[] { 1, 2 };
                case 6:
                    return new int[] { 2, 0 };
                case 7:
                    return new int[] { 2, 1 };
                case 8:
                    return new int[] { 2, 2 };

            }
            return null;
        }

        public static int[] Available(int[] board)
        {
            return board.Where(x => x != 1 && x != 2).ToArray();
        }

        public static Move MiniMax(int[] board, int player)
        {
            int[] available = Available(board);

            if (Winning(board, 1))
                return new Move() { Score = -10 };
            else if (Winning(board, 2))
                return new Move() { Score = 10 };
            else if (available.Length == 0)
                return new Move() { Score = 0 };


            List<Move> moves = new List<Move>();
            Move move;
            for (int i = 0; i < available.Length; i++)
            {
                move = new Move();
                move.Index = available[i];
                board[available[i]] = player;

                if (player == 1)
                    move = MiniMax(board, 2);
                else if (player == 2)
                    move = MiniMax(board, 1);

                board[available[i]] = move.Index;
                moves.Add(move);
            }

            Move bestMove = new Move();
            int bestScore = 0;
            if (player == 1)
            {
                bestScore = -10000;
                foreach (Move trial in moves)
                {
                    if (trial.Score > bestScore)
                    {
                        bestScore = trial.Score;
                        bestMove = trial;
                    }
                }
            }
            else
            {
                bestScore = 10000;
                foreach (Move trial in moves)
                {
                    if (trial.Score < bestScore)
                    {
                        bestScore = trial.Score;
                        bestMove = trial;
                    }
                }
            }
            return bestMove;
        }
    }
}
