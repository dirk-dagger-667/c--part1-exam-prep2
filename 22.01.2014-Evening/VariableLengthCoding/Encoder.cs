using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLengthCoding
{
    class Encoder
    {
        public static string Decoding(string[] inputBytes)
        {
            StringBuilder encodedText = new StringBuilder();

            for (int i = 0; i < inputBytes.Length; i++)
            {
                byte currentByte = byte.Parse(inputBytes[i]);

                for (int j = 0; j < 8; j++)
                {
                    byte mask = (byte)(128 >> j);

                    if ((currentByte & mask) > 0)
                    {
                        encodedText.Append("1");
                    }
                    else
                    {
                        encodedText.Append("0");
                    }
                }
            }

            return encodedText.ToString().TrimEnd('0');
        }

        public static string Decrypting(string decodedEncryptedText, string[] codingTable)
        {
            int counterOfOnes = 0;
            StringBuilder decodedDecryptedText = new StringBuilder();

            for (int i = 0; i < decodedEncryptedText.Length; i++)
            {
                if (decodedEncryptedText[i] == '1')
                {
                    counterOfOnes++;
                }
                else if (decodedEncryptedText[i] == '0')
                {
                    for (int j = 0; j < codingTable.Length ; j++)
                    {
                        if (codingTable[j].Length > 1 && counterOfOnes == int.Parse(codingTable[j].Substring(1, codingTable[j].Length - 1)))
                        {
                            decodedDecryptedText.Append(codingTable[j][0]);
                        }
                        else if (codingTable[j].Length == 1 && counterOfOnes == int.Parse(codingTable[0]))
                        {
                            decodedDecryptedText.Append(" ");
                        }
                    }

                    counterOfOnes = 0;
                }

                if (i == decodedEncryptedText.Length - 1)
                {
                    for (int j = 0; j < codingTable.Length ; j++)
                    {
                        if (codingTable[j].Length > 1 && counterOfOnes == int.Parse(codingTable[j].Substring(1, codingTable[j].Length - 1)))
                        {
                            decodedDecryptedText.Append(codingTable[j][0]);
                        }
                        else if (codingTable[j].Length == 1 && counterOfOnes == int.Parse(codingTable[0]))
                        {
                            decodedDecryptedText.Append(" ");
                        }
                    }
                }
            }

            return decodedDecryptedText.ToString();
        }

        static void Main(string[] args)
        {
            string[] inputBytes = "251 253 214 255 223 187 254 254 183 175 254 240".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int tablesNumberOfLines = int.Parse("11");
            string[] codingTable = " 2 S5 a6 e1 l7 m3 o8 p9 s10 t4 x11".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string decodedEncryptedText = Decoding(inputBytes);
            string decodedDecryptedText = Decrypting(decodedEncryptedText, codingTable);
        }
    }
}
