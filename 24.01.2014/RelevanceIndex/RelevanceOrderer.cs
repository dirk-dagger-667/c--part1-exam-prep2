using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevanceIndex
{
    class RelevanceOrderer
    {
        public static void PrintingInOrder(string[] paragraphs, string searchWord)
        {
            for (int i = 0; i < paragraphs.Length; i++)
            {
                int longestParagraph = 0;
                int bestCounter = 0;

                for (int j = 0; j < paragraphs.Length; j++)
                {
                    int counter = 0;
                    string[] devidedParagraph = paragraphs[j].Split(new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int k = 0; k < devidedParagraph.Length ; k++)
                    {
                        if (devidedParagraph[k] == searchWord)
                        {
                            counter++;
                            devidedParagraph[k] = searchWord.ToUpper();
                        }
                    }

                    if (counter > bestCounter)
                    {
                        longestParagraph = j;
                        bestCounter = counter;
                    }
                }

                Console.WriteLine(paragraphs[longestParagraph]);
                paragraphs[longestParagraph] = "";
            }
        }

        static void Main(string[] args)
        {
            string searchWord = "Text".ToLower();
            int numberOfParagraph = 5;
            string[] paragraphs = new string[numberOfParagraph];
            paragraphs[0] = "if you have someone to text".ToLower();
            paragraphs[1] = "but the text is more than text to text".ToLower();
            paragraphs[2] = "and you need a better text to text".ToLower();
            paragraphs[3] = "try to text what the text would want to text another text with text".ToLower();
            paragraphs[4] = "cause this text is too much about text, and a text will never teach you how to text".ToLower();
            PrintingInOrder(paragraphs, searchWord);
        }
    }
}
