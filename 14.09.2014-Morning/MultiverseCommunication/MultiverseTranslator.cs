using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiverseCommunication
{
    class MultiverseTranslator
    {
        public static string[] ComToSyliblesArray(string inputCommunication)
        {
            string[] comToArray = new string[inputCommunication.Length/3];

            for (int i = 0; i < comToArray.Length; i++)
            {
                StringBuilder sylibles = new StringBuilder();

                for (int j = 0; j < 3; j++)
                {
                    sylibles.Append(inputCommunication[inputCommunication.Length - 3*i + j - 3]);
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
                    case "CHU":
                        sumFromCommunication += 0 * (long)Math.Pow(13, i);
                        break;
                    case "TEL":
                        sumFromCommunication += 1 * (long)Math.Pow(13, i);
                        break;
                    case "OFT":
                        sumFromCommunication += 2 * (long)Math.Pow(13, i);
                        break;
                    case "IVA":
                        sumFromCommunication += 3 * (long)Math.Pow(13, i);
                        break;
                    case "EMY":
                        sumFromCommunication += 4 * (long)Math.Pow(13, i);
                        break;
                    case "VNB":
                        sumFromCommunication += 5 * (long)Math.Pow(13, i);
                        break;
                    case "POQ":
                        sumFromCommunication += 6 * (long)Math.Pow(13, i);
                        break;
                    case "ERI":
                        sumFromCommunication += 7 * (long)Math.Pow(13, i);
                        break;
                    case "CAD":
                        sumFromCommunication += 8 * (long)Math.Pow(13, i);
                        break;
                    case "K-A":
                        sumFromCommunication += 9 * (long)Math.Pow(13, i);
                        break;
                    case "IIA":
                        sumFromCommunication += 10 * (long)Math.Pow(13, i);
                        break;
                    case "YLO":
                        sumFromCommunication += 11 * (long)Math.Pow(13, i);
                        break;
                    case "PLA":
                        sumFromCommunication += 12 * (long)Math.Pow(13, i);
                        break;
                }
            }

            return sumFromCommunication;
        }

        static void Main(string[] args)
        {
            string inputCommunication = "TELERIK-ACADEMY";
            string[] comToArray = ComToSyliblesArray(inputCommunication);
            Console.WriteLine(TranslatingSylibles(comToArray));
        }
    }
}
