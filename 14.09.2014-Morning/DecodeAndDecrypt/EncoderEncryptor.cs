using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class DecoderDecryptor
    {
        public static int ExtractingLengthOfCypher(string input)
        {
            StringBuilder lengthAsString = new StringBuilder();

            for (int i = 0; ; i++)
            {
                if (IsDigitNumber(input[input.Length - i - 1]))
                {
                    lengthAsString.Append(input[input.Length - i - 1]);
                }
                else
                {
                    break;
                }
            }

            return int.Parse(lengthAsString.ToString());
        }

        public static bool IsDigitNumber(char symbol)
        {
            switch (symbol)
            {
                case '0':
                    return true;
                case '1':
                    return true;
                case '2':
                    return true;
                case '3':
                    return true;
                case '4':
                    return true;
                case '5':
                    return true;
                case '6':
                    return true;
                case '7':
                    return true;
                case '8':
                    return true;
                case '9':
                    return true;
                default:
                    return false;
            }
        }

        private static string ExtractingEncodedEncryptedMessage(string input)
        {
            int indexOfLengthOfCypher = input.LastIndexOf(ExtractingLengthOfCypher(input).ToString());
            return input.Substring(0, indexOfLengthOfCypher);
        }

        public static string Decode(string encodedEncryptedMessage)
        {
            StringBuilder decodedMessage = new StringBuilder();
            int numberOfRepeating = 1;

            for (int i = 0; i < encodedEncryptedMessage.Length; i++)
            {
                if (IsDigitNumber(encodedEncryptedMessage[i]) == true)
                {
                    numberOfRepeating = int.Parse(encodedEncryptedMessage[i].ToString());
                }
                else
                {
                    decodedMessage.Append(new String(encodedEncryptedMessage[i], numberOfRepeating));
                    numberOfRepeating = 1;
                }
            }

            return decodedMessage.ToString();
        }

        public static string ExtractingCypher(string decodedEncryptedMessage, int lengthOfCypher)
        {
            StringBuilder cypher = new StringBuilder();

            for (int i = lengthOfCypher; i > 0; i--)
            {
                cypher.Append(decodedEncryptedMessage[decodedEncryptedMessage.Length - i]);
            }

            return cypher.ToString();
        }

        private static string ExtractingDecodedMessage(string decodedEncryptedMessage, int lengthOfCypher)
        {
            return decodedEncryptedMessage.Substring(0, decodedEncryptedMessage.Length - lengthOfCypher);
        }

        public static string EncryptDecrypt(string encryptedMessage, string cypher, string cyphering)
        {
            int counter = 0;
            int code = 0;
            StringBuilder decryptedMessage = new StringBuilder();
            char encryptedChar;

            if (encryptedMessage.Length > cypher.Length)
            {
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    if (counter == cypher.Length)
                    {
                        counter = 0;
                    }

                    code = cyphering.IndexOf(encryptedMessage[i]) ^ cyphering.IndexOf(cypher[counter]);
                    encryptedChar = (char)(65 + code);
                    decryptedMessage.Append(encryptedChar);
                    counter++;
                }
            }
            else if (encryptedMessage.Length < cypher.Length)
            {
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    counter = 0;

                    while ((i + counter * encryptedMessage.Length) < cypher.Length)
                    {
                        code = cyphering.IndexOf(encryptedMessage[i]) ^ cyphering.IndexOf(cypher[i + counter * encryptedMessage.Length]);
                        encryptedChar = (char)(65 + code);
                        decryptedMessage.Append(encryptedChar);
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < encryptedMessage.Length; i++)
                {
                    code = cyphering.IndexOf(encryptedMessage[i]) ^ cyphering.IndexOf(cypher[i]);
                    encryptedChar = (char)(65 + code);
                    decryptedMessage.Append(encryptedChar);
                }
            }

            return decryptedMessage.ToString();
        }

        static void Main(string[] args)
        {
            string cyphering = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string input = "KKICXDE3P5";
            int lengthOfCypher = ExtractingLengthOfCypher(input);
            string encodedEncryptedMessage = ExtractingEncodedEncryptedMessage(input);
            string decodedEncryptedMessage = Decode(encodedEncryptedMessage);
            string cypher = ExtractingCypher(decodedEncryptedMessage, lengthOfCypher);
            string decodedMessage = ExtractingDecodedMessage(decodedEncryptedMessage, lengthOfCypher);
            string originalMessage = EncryptDecrypt(decodedMessage, cypher, cyphering);
        }
    }
}
