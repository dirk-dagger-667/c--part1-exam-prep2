using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StrangeLandNumbers
{
    class StrangeLandTranslator
    {
        public static string NonesenseToSiximal(string nonesense)
        {
            StringBuilder seximalNumber = new StringBuilder();
            int counter = 0;

            for (int i = 0; i < nonesense.Length; i++)
            {
                switch (nonesense[i])
                {
                    case 'f':
                        seximalNumber.Append("0");
                        break;
                    case 'b':
                        seximalNumber.Append("1");
                        i += 2;
                        break;
                    case 'o':
                        seximalNumber.Append("2");
                        i += 4;
                        break;
                    case 'm':
                        seximalNumber.Append("3");
                        i += 6;
                        break;
                    case 'l':
                        seximalNumber.Append("4");
                        i += 5;
                        break;
                    case 'p':
                        seximalNumber.Append("5");
                        i += 3;
                        break;
                    case 'h':
                        seximalNumber.Append("6");
                        i += 1;
                        break;
                }

                counter++;
            }

            return seximalNumber.ToString();
        }

        public static BigInteger SiximalToDecimal(string siximalNumber)
        {
            BigInteger decimalNumber = new BigInteger();

            for (int i = 0; i < siximalNumber.Length; i++)
            {
                switch (siximalNumber[siximalNumber.Length - 1 - i])
                {
                    case '0':
                        decimalNumber += 0 *(BigInteger)Math.Pow(7, i);
                        break;
                    case '1':
                        decimalNumber += 1 * (BigInteger)Math.Pow(7, i);
                        break;
                    case '2':
                        decimalNumber += 2 * (BigInteger)Math.Pow(7, i);
                        break;
                    case '3':
                        decimalNumber += 3 * (BigInteger)Math.Pow(7, i);
                        break;
                    case '4':
                        decimalNumber += 4 * (BigInteger)Math.Pow(7, i);
                        break;
                    case '5':
                        decimalNumber += 5 * (BigInteger)Math.Pow(7, i);
                        break;
                    case '6':
                        decimalNumber += 6 * (BigInteger)Math.Pow(7, i);
                        break;
                }
            }

            return decimalNumber;
        }

        static void Main(string[] args)
        {
            string nonesense = "hTmNTRAVLoBJEClPVKNQfffoBJECpNWE";
            string siximalNumber = NonesenseToSiximal(nonesense);
            Console.WriteLine(SiximalToDecimal(siximalNumber));
        }
    }
}
