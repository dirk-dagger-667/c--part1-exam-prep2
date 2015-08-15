using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TRES4Numbers
{
    class TRES4nianTranslator
    {
        public static string DecimalToNinal(string decimalNumber)
        {
            BigInteger numberInDecimal = BigInteger.Parse(decimalNumber);
            StringBuilder ninalNumberString = new StringBuilder();
            int remainder = 0;

            while (numberInDecimal != 0)
            {
                remainder = (int)(numberInDecimal % 9);
                numberInDecimal = numberInDecimal / 9;
                ninalNumberString.Append(remainder);
            }

            return ninalNumberString.ToString();
        }

        public static string NinalToZerg(string ninal)
        {
            StringBuilder zerg = new StringBuilder();

            for (int i = 0; i < ninal.Length; i++)
            {
                switch (ninal[ninal.Length - 1 - i])
                {
                    case '0':
                        zerg.Append("LON+");
                        break;
                    case '1':
                        zerg.Append("VK-");
                        break;
                    case '2':
                        zerg.Append("*ACAD");
                        break;
                    case '3':
                        zerg.Append("^MIM");
                        break;
                    case '4':
                        zerg.Append("ERIK|");
                        break;
                    case '5':
                        zerg.Append("SEY&");
                        break;
                    case '6':
                        zerg.Append("EMY>>");
                        break;
                    case '7':
                        zerg.Append("/TEL");
                        break;
                    case '8':
                        zerg.Append("<<DON");
                        break;
                }
            }

            return zerg.ToString();
        }

        static void Main(string[] args)
        {
            string decimalNumber = "891672";
            Console.WriteLine(DecimalToNinal(decimalNumber.Trim('-')));
            Console.WriteLine(NinalToZerg(DecimalToNinal(decimalNumber)));
        }
    }
}
