using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidSudoku
    {
        public bool Sollution(char[,] board)
        {
            var rowLength = board.GetLength(0);
            var collumLength = board.GetLength(1);
            var validator = new SudoKuValidator(collumLength);
            for (int row = 0; row < rowLength; row++)
            {
                for (int collum = 0; collum < collumLength; collum++)
                {
                    if (row == 0)
                    {
                        validator = new SudoKuValidator(collumLength);
                        for (int i = 0; i < collumLength; i++)
                        {
                            if (!validator.Push(board[i, collum] - 49))
                                return false;
                        }
                    }
                    if (collum == 0)
                    {
                        validator = new SudoKuValidator(collumLength);
                        for (int i = 0; i < rowLength; i++)
                        {
                            if (!validator.Push(board[row, i] - 49))
                                return false;
                        }
                    }
                    if (row % 3 == 0 && collum % 3 == 0)
                    {
                        validator = new SudoKuValidator(collumLength);
                        for (int i = row; i < row + 3; i++)
                        {
                            for (int j = collum; j < collum + 3; j++)
                            {
                                if (!validator.Push(board[i, j] - 49))
                                    return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool Sollution_Fast(char[,] board)
        {
            var rowLength = board.GetLength(0);
            var collumLength = board.GetLength(1);
            var validator = default(SudoKuValidator);
            for (int row = 0; row < rowLength; row++)
            {
                validator = new SudoKuValidator(collumLength);
                for (int collum = 0; collum < collumLength; collum++)
                {
                    if (!validator.Push(board[row, collum] - 49))
                        return false;
                }
            }
            for (int collum = 0; collum < collumLength; collum++)
            {
                validator = new SudoKuValidator(collumLength);
                for (int row = 0; row < rowLength; row++)
                {
                    if (!validator.Push(board[row, collum] - 49))
                        return false;
                }
            }
            for (int row = 0; row < rowLength; row += 3)
            {
                for (int collum = 0; collum < collumLength; collum += 3)
                {
                    validator = new SudoKuValidator(collumLength);
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = collum; j < collum + 3; j++)
                        {
                            if (!validator.Push(board[i, j] - 49))
                                return false;
                        }
                    }
                }
            }
            return true;
        }

        public class SudoKuValidator
        {
            private BitArray flags;

            public SudoKuValidator(int length)
            {
                flags = new BitArray(length);
            }

            public bool Push(int value)
            {
                if (value > -1 && value < flags.Length)
                {
                    if (flags[value])
                        return false;
                    else
                    {
                        flags[value] = true;
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }

            public void Clear()
            {
                flags.SetAll(false);
            }
        }
    }
}
