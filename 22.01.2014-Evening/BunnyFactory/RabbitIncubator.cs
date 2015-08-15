using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BunnyFactory
{
    class RabbitIncubator
    {
        public static List<int> InputCagesWithRabbits()
        {
            string input = Console.ReadLine();
            List<int> inputList = new List<int>();

            while (input != "END")
            {
                inputList.Add(int.Parse(input));
                input = Console.ReadLine();
            }

            return inputList;
        }

        public static StringBuilder InputIntListToStringBuilder(List<int> cagesWithBunnies)
        {
            StringBuilder cagesWithBunniesString = new StringBuilder();

            for (int i = 0; i < cagesWithBunnies.Count; i++)
            {
                cagesWithBunniesString.Append(cagesWithBunnies[i]);
            }

            return cagesWithBunniesString;
        }

        public static void GoingThroughTheAlgorithm(List<int> cagesWithBunnies)
        {
            for (int i = 0; ; i++)
            {
                int s = 0;
                StringBuilder numberToString = InputIntListToStringBuilder(cagesWithBunnies);
                BigInteger product = 1;
                int sum = 0;

                for (int k = 0; k <= i; k++)
                {
                    s += cagesWithBunnies[k];
                }

                if (s > numberToString.Length - i || i > numberToString.Length - i)
                {
                    PrintCagesOfBunnies(numberToString);
                    break;
                }

                for (int j = i + 1; j <= s + i; j++)
                {
                    sum += cagesWithBunnies[j];
                    product *= cagesWithBunnies[j];
                }
                StringBuilder newNumberToString = new StringBuilder();
                newNumberToString.Append(sum);
                newNumberToString.Append(product);

                if (i == 0)
                {
                    newNumberToString.Append(numberToString.ToString().Substring(newNumberToString.Length, numberToString.Length - s - 1));
                }
                else
                {
                    newNumberToString.Append(numberToString.ToString().Substring(newNumberToString.Length + 1, numberToString.Length - s - 2));
                }

                StringBuilder without0And1 = RemovingOnesAndZeros(newNumberToString);
                cagesWithBunnies = StringOfCagesIntoListOfInt(without0And1);
            }
        }

        public static StringBuilder RemovingOnesAndZeros(StringBuilder numberToString)
        {
            StringBuilder newStringOfCages = new StringBuilder();

            for (int i = 0; i < numberToString.Length; i++)
            {
                if (numberToString[i] != '0' && numberToString[i] != '1')
                {
                    newStringOfCages.Append(numberToString[i]);
                }
                else
                {
                    continue;
                }
            }

            return newStringOfCages;
        }

        public static List<int> StringOfCagesIntoListOfInt(StringBuilder without0And1)
        {
            List<int> listOfCages = new List<int>();

            for (int i = 0; i < without0And1.Length; i++)
            {
                listOfCages.Add(int.Parse(without0And1[i].ToString()));
            }

            return listOfCages;
        }

        public static void PrintCagesOfBunnies(StringBuilder numberToString)
        {
            for (int i = 0; i < numberToString.Length - 1; i++)
            {
                Console.Write(numberToString[i] + " ");
            }

            Console.Write(numberToString[numberToString.Length - 1]);
        }

        static void Main(string[] args)
        {
            StringBuilder stringOfCages = new StringBuilder();
            stringOfCages.Append("325548495634");
            List<int> listOfCages = StringOfCagesIntoListOfInt(stringOfCages);
            GoingThroughTheAlgorithm(listOfCages);
        }
    }
}
