using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodingAndEncrypting
{
    class EncoderAndEncryptor
    {
        public static string Encode(string encryptedMessage)
        {
            int counterOfChar = 1;
            StringBuilder encodedEncryptedMessage = new StringBuilder();

            for (int i = 1; i < encryptedMessage.Length; i++)
            {
                if (encryptedMessage[i - 1] == encryptedMessage[i])
                {
                    counterOfChar++;
                }
                else
                {
                    if (counterOfChar > 2)
                    {
                        encodedEncryptedMessage.Append(counterOfChar.ToString());
                        encodedEncryptedMessage.Append(new String(encryptedMessage[i - 1], counterOfChar));
                        counterOfChar = 1;
                    }
                    else
                    {
                        encodedEncryptedMessage.Append(encryptedMessage[i]);
                    }
                }
            }

            return encodedEncryptedMessage.ToString();
        }

        public static string EncryptDecrypt(string message, string cypher, string cyphering)
        {
            int counter = 0;
            int code = 0;
            StringBuilder decryptedMessage = new StringBuilder();
            char encryptedChar;

            if (message.Length > cypher.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    if (counter == cypher.Length)
                    {
                        counter = 0;
                    }

                    code = cyphering.IndexOf(message[i]) ^ cyphering.IndexOf(cypher[counter]);
                    encryptedChar = (char)(65 + code);
                    decryptedMessage.Append(encryptedChar);
                    counter++;
                }
            }
            else if (message.Length < cypher.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    counter = 0;

                    while ((i + counter * message.Length) < cypher.Length)
                    {
                        code = cyphering.IndexOf(message[i]) ^ cyphering.IndexOf(cypher[i + counter * message.Length]);
                        encryptedChar = (char)(65 + code);
                        decryptedMessage.Append(encryptedChar);
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    code = cyphering.IndexOf(message[i]) ^ cyphering.IndexOf(cypher[i]);
                    encryptedChar = (char)(65 + code);
                    decryptedMessage.Append(encryptedChar);
                }
            }

            return decryptedMessage.ToString();
        }

        static void Main(string[] args)
        {
            string cyphering = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string message = "JOHNY";
            string cypher = "DEPPP";
            string encryptedMessage = EncryptDecrypt(message, cypher, cyphering);
            string encodedEncryptedMessage = Encode(encryptedMessage);
        }
    }
}
