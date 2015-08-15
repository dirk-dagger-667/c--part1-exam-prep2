using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingLetters
{
    class Encryptor
    {
        public static string[] SplittingInputStringIntoArray(string inputString)
        {
            return inputString.Split(new char[] { ',', ' ' });
        }

        public static string JumblingUpWords(string[] splitWords)
        {
            string longestWord = FindLongestWord(splitWords);
            StringBuilder jumbledUpLetters = new StringBuilder();

            for (int i = 0; i < longestWord.Length; i++)
            {
                for (int j = 0; j < splitWords.Length; j++)
                {
                    if (i < splitWords[j].Length)
                    {
                        jumbledUpLetters.Append(splitWords[j][splitWords[j].Length - 1 - i]);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return jumbledUpLetters.ToString();
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

        public static char[] MovingLetters(string jumbledUpLetters)
        {
            char[] movedLetters = jumbledUpLetters.ToCharArray();
            char[] oldStateOfMovedLetters = new char[movedLetters.Length];

            for (int i = 0; i < movedLetters.Length; i++)
            {
                int numberOfMoves = FindMovingCount(movedLetters, i);
                Array.Copy(movedLetters, oldStateOfMovedLetters, movedLetters.Length);

                if (numberOfMoves + i < jumbledUpLetters.Length)
                {
                    movedLetters[numberOfMoves + i] = movedLetters[i];

                    for (int j = numberOfMoves - 1 + i; j >= i; j--)
                    {
                        movedLetters[j] = oldStateOfMovedLetters[j + 1];
                    }
                }
                else
                {
                    movedLetters[numberOfMoves + i - movedLetters.Length] = movedLetters[i];

                    for (int j = numberOfMoves + i - movedLetters.Length + 1; j <= i  ; j++)
                    {
                        movedLetters[j] = oldStateOfMovedLetters[j - 1];
                    }
                }
            }

            return movedLetters;
        }

        public static void PrintMovedLetters(char[] movedLetters)
        {
            StringBuilder stringOfMovedLetters = new StringBuilder();

            for (int i = 0; i < movedLetters.Length; i++)
            {
                stringOfMovedLetters.Append(movedLetters[i]);
            }

            Console.WriteLine(stringOfMovedLetters.ToString());
        }

        public static int FindMovingCount(char[] jumbledUpLettersToArray, int numberCounter)
        {
            int numberOfMoves = jumbledUpLettersToArray[numberCounter].ToString().ToLower()[0] - 96;

            while (numberOfMoves > jumbledUpLettersToArray.Length)
            {
                numberOfMoves = numberOfMoves - jumbledUpLettersToArray.Length;
            }

            return numberOfMoves;
        }

        static void Main(string[] args)
        {
            string inputWords = "Fun exam right";
            string[] arrayOfWords = SplittingInputStringIntoArray(inputWords);
            string jumbledUpLetters = JumblingUpWords(arrayOfWords);
            char[] movedLetters = MovingLetters(jumbledUpLetters);
            PrintMovedLetters(movedLetters);
        }
    }
}
