using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Patters
{
    class MaximumSumFinder
    {
        public static BigInteger[,] StringToIntGrid(string[] inputNumbersInCells, int numberOfRowsCols)
        {
            int counter = 0;
            BigInteger[,] grid = new BigInteger[numberOfRowsCols, numberOfRowsCols];

            for (int i = 0; i < numberOfRowsCols; i++)
            {
                for (int j = 0; j < numberOfRowsCols; j++)
                {
                    grid[i, j] = BigInteger.Parse(inputNumbersInCells[counter]);
                    counter++;
                }
            }

            return grid;
        }

        public static void PrintingResult(bool pattern, BigInteger sum, int numberOfRowsAndCols, BigInteger[,] grid)
        {
            if (pattern == true)
            {
                Console.WriteLine("YES {0}", sum);
            }
            else
            {
                int j = 0;
                BigInteger diagonal = 0;

                for (int i = 0; i < numberOfRowsAndCols && j < numberOfRowsAndCols; i++, j++)
                {
                    diagonal += grid[i, j];
                }

                Console.WriteLine("NO {0}", diagonal);
            }
        }

        static void Main(string[] args)
        {
            int numberOFRowsAndCols = int.Parse(Console.ReadLine());
            string[] inputNumbersInCells = "1 2 3 4 5 2 3 4 5 6 3 4 5 6 7 4 5 6 7 8 5 6 7 8 9".Split(new char[] {' '});
            BigInteger[,] grid = StringToIntGrid(inputNumbersInCells, numberOFRowsAndCols);
            bool atLeastOnePattern = false;
            BigInteger sum = 0;

            for (int i = 0; i < numberOFRowsAndCols - 2; i++)
            {
                for (int j = 0; j < numberOFRowsAndCols - 4; j++)
                {
                    BigInteger firstCell = grid[i, j];
                    BigInteger secondCell = grid[i, j + 1];
                    BigInteger thirdCell = grid[i, j + 2];
                    BigInteger fourthCell = grid[i + 1, j + 2];
                    BigInteger fifthCell = grid[i + 2, j + 2];
                    BigInteger sixthCell = grid[i + 2, j + 3];
                    BigInteger seventhCell = grid[i + 2, j + 4];

                    if (firstCell + 1 == secondCell && secondCell + 1 == thirdCell && thirdCell + 1 == fourthCell && fourthCell + 1 == fifthCell
                        && fifthCell + 1 == sixthCell && sixthCell + 1 == seventhCell)
                    {
                        if (sum < (firstCell + secondCell + thirdCell + fourthCell + fifthCell + sixthCell + seventhCell))
                        {
                            sum = firstCell + secondCell + thirdCell + fourthCell + fifthCell + sixthCell + seventhCell;
                            atLeastOnePattern = true;
                        }
                    }
                }   
            }

            PrintingResult(atLeastOnePattern, sum, numberOFRowsAndCols, grid);
        }
    }
}
