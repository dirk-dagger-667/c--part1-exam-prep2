using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class ZergTranslator
    {
        public static string[] ComToSyliblesArray(string inputCommunication)
        {
            string[] comToArray = new string[inputCommunication.Length / 4];

            for (int i = 0; i < comToArray.Length; i++)
            {
                StringBuilder sylibles = new StringBuilder();

                for (int j = 0; j < 4; j++)
                {
                    sylibles.Append(inputCommunication[inputCommunication.Length - 4 * i + j - 4]);
                }

                comToArray[i] = sylibles.ToString();
            }

            return comToArray;
        }

        public static long TranslatingSylibles(string[] sylibles)
        {
            long sumFromCommunication = 0;

            for (int i = 0; i < sylibles.Length; i++)
            {
                switch (sylibles[i])
                {
                    case "Rawr":
                        sumFromCommunication += 0 * (long)Math.Pow(15, i);
                        break;
                    case "Rrrr":
                        sumFromCommunication += 1 * (long)Math.Pow(15, i);
                        break;
                    case "Hsst":
                        sumFromCommunication += 2 * (long)Math.Pow(15, i);
                        break;
                    case "Ssst":
                        sumFromCommunication += 3 * (long)Math.Pow(15, i);
                        break;
                    case "Grrr":
                        sumFromCommunication += 4 * (long)Math.Pow(15, i);
                        break;
                    case "Rarr":
                        sumFromCommunication += 5 * (long)Math.Pow(15, i);
                        break;
                    case "Mrrr":
                        sumFromCommunication += 6 * (long)Math.Pow(15, i);
                        break;
                    case "Psst":
                        sumFromCommunication += 7 * (long)Math.Pow(15, i);
                        break;
                    case "Uaah":
                        sumFromCommunication += 8 * (long)Math.Pow(15, i);
                        break;
                    case "Uaha":
                        sumFromCommunication += 9 * (long)Math.Pow(15, i);
                        break;
                    case "Zzzz":
                        sumFromCommunication += 10 * (long)Math.Pow(15, i);
                        break;
                    case "Bauu":
                        sumFromCommunication += 11 * (long)Math.Pow(15, i);
                        break;
                    case "Djav":
                        sumFromCommunication += 12 * (long)Math.Pow(15, i);
                        break;
                    case "Myau":
                        sumFromCommunication += 13 * (long)Math.Pow(15, i);
                        break;
                    case "Gruh":
                        sumFromCommunication += 14 * (long)Math.Pow(15, i);
                        break;
                }
            }

            return sumFromCommunication;
        }

        static void Main(string[] args)
        {
            string inputCommunication = "GruhMyauDjav";
            string[] comToArray = ComToSyliblesArray(inputCommunication);
            Console.WriteLine(TranslatingSylibles(comToArray));
        }
    }
}
