using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class PatternFinder
    {
        public static int[,] StringToIntGrid(string[] inputNumbersInCells, int numberOfRowsCols)
        {
            int counter = 0;
            int[,] grid = new int[numberOfRowsCols, numberOfRowsCols];

            for (int i = 0; i < numberOfRowsCols; i++)
            {
                for (int j = 0; j < numberOfRowsCols; j++)
                {
                    grid[i, j] = int.Parse(inputNumbersInCells[counter]);
                    counter++;
                }
            }

            return grid;
        }

        static void Main(string[] args)
        {
            int numberOFRowsAndCols = int.Parse(Console.ReadLine()) - 1;
            string[] inputNumbersInCells = "9 9 9 2 2 2 9 9 9 2 2 2 9 9 9 2 2 2 9 9 9 2 2 2 9 9 9 2 2 2 9 9 9 2 2 2".Split(new char[] { ' ' });
            int[,] grid = StringToIntGrid(inputNumbersInCells, numberOFRowsAndCols);
            int sum = 0;
            int currentPositionRows = 0;
            int currentPositionCols = 0;

            for (int i = 0; i < numberOFRowsAndCols - 4; i++)
            {
                for (int j = 0; j < numberOFRowsAndCols - 2; j++)
                {
                    currentPositionRows = i;
                    currentPositionCols = j;

                    if (grid[currentPositionRows, currentPositionCols] == 3
                        && grid[currentPositionRows, currentPositionCols + 1] == 3
                        && grid[currentPositionRows, currentPositionCols + 2] == 3
                        && grid[currentPositionRows + 1, currentPositionCols + 2] == 3
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 3
                        && grid[currentPositionRows + 2, currentPositionCols + 2] == 3
                        && grid[currentPositionRows + 3, currentPositionCols + 2] == 3
                        && grid[currentPositionRows + 4, currentPositionCols] == 3
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 3
                        && grid[currentPositionRows + 4, currentPositionCols + 2] == 3)
                    {
                        sum += 3;
                    }
                    else if (grid[currentPositionRows, currentPositionCols] == 4
                        && grid[currentPositionRows, currentPositionCols + 2] == 4
                        && grid[currentPositionRows + 1, currentPositionCols] == 4
                        && grid[currentPositionRows + 1, currentPositionCols + 2] == 4
                        && grid[currentPositionRows + 2, currentPositionCols] == 4
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 4
                        && grid[currentPositionRows + 2, currentPositionCols + 2] == 4
                        && grid[currentPositionRows + 3, currentPositionCols + 2] == 4
                        && grid[currentPositionRows + 4, currentPositionCols + 2] == 4)
                    {
                        sum += 4;
                    }
                    else if (grid[currentPositionRows, currentPositionCols] == 5
                        && grid[currentPositionRows, currentPositionCols + 1] == 5
                        && grid[currentPositionRows, currentPositionCols + 2] == 5
                        && grid[currentPositionRows + 1, currentPositionCols] == 5
                        && grid[currentPositionRows + 2, currentPositionCols] == 5
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 5
                        && grid[currentPositionRows + 2, currentPositionCols + 2] == 5
                        && grid[currentPositionRows + 3, currentPositionCols + 2] == 5
                        && grid[currentPositionRows + 4, currentPositionCols] == 5
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 5
                        && grid[currentPositionRows + 4, currentPositionCols + 2] == 5)
                    {
                        sum += 5;
                    }
                    else if (grid[currentPositionRows, currentPositionCols] == 6
                        && grid[currentPositionRows, currentPositionCols + 1] == 6
                        && grid[currentPositionRows, currentPositionCols + 2] == 6
                        && grid[currentPositionRows + 1, currentPositionCols] == 6
                        && grid[currentPositionRows + 2, currentPositionCols] == 6
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 6
                        && grid[currentPositionRows + 2, currentPositionCols + 2] == 6
                        && grid[currentPositionRows + 3, currentPositionCols] == 6
                        && grid[currentPositionRows + 3, currentPositionCols + 2] == 6
                        && grid[currentPositionRows + 4, currentPositionCols] == 6
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 6
                        && grid[currentPositionRows + 4, currentPositionCols + 2] == 6)
                    {
                        sum += 6;
                    }
                    else if (grid[currentPositionRows, currentPositionCols] == 7
                        && grid[currentPositionRows, currentPositionCols + 1] == 7
                        && grid[currentPositionRows, currentPositionCols + 2] == 7
                        && grid[currentPositionRows + 1, currentPositionCols + 2] == 7
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 7
                        && grid[currentPositionRows + 3, currentPositionCols + 1] == 7
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 7)
                    {
                        sum += 7;
                    }
                    else if (grid[currentPositionRows, currentPositionCols] == 8
                        && grid[currentPositionRows, currentPositionCols + 1] == 8
                        && grid[currentPositionRows, currentPositionCols + 2] == 8
                        && grid[currentPositionRows + 1, currentPositionCols] == 8
                        && grid[currentPositionRows + 1, currentPositionCols + 2] == 8
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 8
                        && grid[currentPositionRows + 3, currentPositionCols] == 8
                        && grid[currentPositionRows + 3, currentPositionCols + 2] == 8
                        && grid[currentPositionRows + 4, currentPositionCols] == 8
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 8
                        && grid[currentPositionRows + 4, currentPositionCols + 2] == 8)
                    {
                        sum += 8;
                    }
                    else if (grid[currentPositionRows, currentPositionCols] == 9
                        && grid[currentPositionRows, currentPositionCols + 1] == 9
                        && grid[currentPositionRows, currentPositionCols + 2] == 9
                        && grid[currentPositionRows + 1, currentPositionCols] == 9
                        && grid[currentPositionRows + 1, currentPositionCols + 2] == 9
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 9
                        && grid[currentPositionRows + 3, currentPositionCols] == 9
                        && grid[currentPositionRows + 3, currentPositionCols + 2] == 9
                        && grid[currentPositionRows + 4, currentPositionCols] == 9
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 9
                        && grid[currentPositionRows + 4, currentPositionCols + 2] == 9)
                    {
                        sum += 9;
                    }
                }
            }

            for (int k = 0; k < numberOFRowsAndCols - 4; k++)
            {
                for (int l = 2; l < numberOFRowsAndCols; l++)
                {
                    currentPositionRows = k;
                    currentPositionCols = l;

                    if (grid[currentPositionRows, currentPositionCols] == 1
                        && grid[currentPositionRows + 1, currentPositionCols - 1] == 1
                        && grid[currentPositionRows + 1, currentPositionCols] == 1
                        && grid[currentPositionRows + 2, currentPositionCols - 2] == 1
                        && grid[currentPositionRows + 2, currentPositionCols] == 1
                        && grid[currentPositionRows + 3, currentPositionCols] == 1
                        && grid[currentPositionRows + 4, currentPositionCols] == 1)
                    {
                        sum += 1;
                    }
                }
            }

            for (int k = 0; k < numberOFRowsAndCols - 4; k++)
            {
                for (int l = 1; l < numberOFRowsAndCols - 1; l++)
                {
                    currentPositionRows = k;
                    currentPositionCols = l;

                    if (grid[currentPositionRows, currentPositionCols] == 2
                        && grid[currentPositionRows + 1, currentPositionCols - 1] == 2
                        && grid[currentPositionRows + 1, currentPositionCols + 1] == 2
                        && grid[currentPositionRows + 2, currentPositionCols + 1] == 2
                        && grid[currentPositionRows + 3, currentPositionCols] == 2
                        && grid[currentPositionRows + 4, currentPositionCols - 1] == 2
                        && grid[currentPositionRows + 4, currentPositionCols] == 2
                        && grid[currentPositionRows + 4, currentPositionCols + 1] == 2)
                    {
                        sum += 2;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
