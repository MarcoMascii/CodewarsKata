using System;

namespace CodewarsSolution
{
    public class Sudoku
    {
        static bool _isValid = true;
        public Sudoku(int[][] sudokuData)
        {
            int boxLenght = sudokuData.Length;
            int littleBoxLenght = (int)Math.Sqrt(boxLenght);
            if (littleBoxLenght * littleBoxLenght != boxLenght)
            {
                _isValid = false;
                return;
            }
            int factorial = 1;
            for (int i = 1; i <= boxLenght; i++)
            {
                factorial *= i;
            }

            int validRow = 1;
            int validColumn = 1;
            for (int i = 0; i < boxLenght; i++)
            {
                if (boxLenght != sudokuData[i].Length)
                {
                    _isValid = false;
                    return;
                }
                validRow = 1;
                validColumn = 1;
                for (int j = 0; j < boxLenght; j++)
                {
                    if (sudokuData[i][j] == 0)
                    {
                        _isValid = false;
                        return;
                    }
                    validColumn *= sudokuData[j][i];
                    validRow *= sudokuData[i][j];
                }

                if (validRow != factorial || validColumn != factorial)
                {
                    _isValid = false;
                    return;
                }
            }

            int validSubSquare = 1;
            for (int i = 0; i < Math.Sqrt( boxLenght); i++)
            {
                for (int j = 0; j < Math.Sqrt(boxLenght); j++)
                {
                    validSubSquare *= sudokuData[j][i];
                }
            }
            if (validSubSquare != factorial)
            {
                _isValid = false;
                return;
            }

        }

        public bool IsValid()
        {
            return _isValid;
        }
    }
}
