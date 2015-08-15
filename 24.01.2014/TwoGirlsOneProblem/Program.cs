using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TwoGirlsOneProblem
{
    class Program
    {
        public static List<int> InputStringToArray(string input)
        {
            List<int> listOfFlowerCells = new List<int>();
            string[] withoutWhiteSpaces = input.Split(new char[] { ' ' });

            for (int i = 0; i < withoutWhiteSpaces.Length; i++)
            {
                listOfFlowerCells.Add(int.Parse(withoutWhiteSpaces[i]));
            }

            return listOfFlowerCells;
        }

        public static void PlayingTheGirlsGame(List<int> listOfFlowerCells)
        {
            int numberOfCells = listOfFlowerCells.Count;
            int mollyCellPosition = 0;
            int dollyCellPosition = listOfFlowerCells.Count - 1;
            BigInteger flowersOfMolly = 0;
            BigInteger flowersOfDolly = 0;

            while (true)
            {
                if (listOfFlowerCells[mollyCellPosition] == 0)
                {
                    Console.WriteLine("Dolly");
                    Console.WriteLine("{0} {1}", flowersOfMolly, flowersOfDolly );
                    break;
                }
                else if (listOfFlowerCells[dollyCellPosition] == 0)
                {
                    Console.WriteLine("Molly");
                    Console.WriteLine("{0} {1}", flowersOfMolly, flowersOfDolly);
                    break;
                }

                if (mollyCellPosition == dollyCellPosition)
                {
                    if (listOfFlowerCells[mollyCellPosition] % 2 == 0)
                    {
                        flowersOfMolly += listOfFlowerCells[mollyCellPosition] / 2;
                        flowersOfDolly += listOfFlowerCells[dollyCellPosition] / 2;
                        listOfFlowerCells[mollyCellPosition] = 0;
                    }
                    else
                    {
                        flowersOfMolly += (listOfFlowerCells[mollyCellPosition] - 1) / 2;
                        flowersOfDolly += (listOfFlowerCells[dollyCellPosition] - 1) / 2;
                        listOfFlowerCells[mollyCellPosition] = 1;
                    }

                    mollyCellPosition = GettingNextPosition(flowersOfMolly, numberOfCells);
                    dollyCellPosition = GettingNextPosition(flowersOfDolly, numberOfCells);
                }
                else
                {
                    flowersOfMolly += listOfFlowerCells[mollyCellPosition];
                    flowersOfDolly += listOfFlowerCells[dollyCellPosition];
                    listOfFlowerCells[mollyCellPosition] = 0;
                    listOfFlowerCells[dollyCellPosition] = 0;
                    mollyCellPosition = GettingNextPosition(flowersOfMolly, numberOfCells);
                    dollyCellPosition = numberOfCells - 1 - GettingNextPosition(flowersOfDolly, numberOfCells);
                }
            }
        }

        public static int GettingNextPosition(BigInteger flowers, int lengthOfList)
        {
            BigInteger flowersInCell = flowers;

            while (flowersInCell > lengthOfList)
            {
                flowersInCell -= lengthOfList;
            }

            int position = (int)flowersInCell;
            return position;
        }

        static void Main(string[] args)
        {
            string input = "4 17 4 2 7 11 3 2";
            List<int> listOfFlowerCells = InputStringToArray(input);
            PlayingTheGirlsGame(listOfFlowerCells);
        }
    }
}
