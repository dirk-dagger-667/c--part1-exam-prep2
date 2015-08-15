using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWords
{
    class WordRearranger
    {
        public static string[] InputToArray(int numberOfWords)
        {
            string[] arrayOfWords = new string[numberOfWords];

            for (int i = 0; i < numberOfWords; i++)
            {
                arrayOfWords[i] = Console.ReadLine();
            }

            return arrayOfWords;
        }

        public static string[] WordScrambler(string[] unscrambledArray)
        {
            string[] scrabledWords = new string[unscrambledArray.Length];

            for (int i = 0; i < unscrambledArray.Length; i++)
            {
                scrabledWords[unscrambledArray[i].Length % (unscrambledArray.Length)] = unscrambledArray[i];
            }

            return scrabledWords;
        }

        public static void PrinterOfWords(string[] scrambledArray)
        {
            string longestWordOfArray = FindLongestWord(scrambledArray);

            for (int i = 0; i < longestWordOfArray.Length; i++)
            {
                for (int j = 0; j < scrambledArray.Length; j++)
                {
                    if (i < scrambledArray[j].Length)
                    {
                        Console.Write(scrambledArray[j][i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public static string FindLongestWord(string[] scrambledArray)
        {
            string longestWord = string.Empty;

            for (int i = 0; i < scrambledArray.Length; i++)
            {
                if (scrambledArray[i].Length > longestWord.Length)
                {
                    longestWord = scrambledArray[i];
                }
            }

            return longestWord;
        }
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            string[] arrayOfWords = InputToArray(numberOfWords);
            string[] jubledUpListOfWords = WordScrambler(arrayOfWords);
            PrinterOfWords(arrayOfWords);
        }
    }
}
