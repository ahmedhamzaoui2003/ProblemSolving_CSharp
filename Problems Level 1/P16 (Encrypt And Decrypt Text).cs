using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P16__Encrypt_And_Decrypt_Text_
    {

        static public int ReadNumber(string message)
        {
            int num;
            do
            {
                Console.WriteLine(message);
                num = Convert.ToInt32(Console.ReadLine());

            } while (num <= 0);

            return num;
        }
        static public string ReadString(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            return str;
        }

        static public string Encrypt(string Text , int EncryptionKey)
        {
            string EncryptedText = "";
            
            foreach (char c in Text) {
                char newCharacter = (char)((int)(c) + EncryptionKey) ;
                EncryptedText += newCharacter.ToString();
}
            return EncryptedText;        
        }


        static public string Decrypt(string Text , int DecryptionKey)
        {
            string DecryptedText = "";

            foreach (char c in Text)
            {
                char newCharacter = (char)((int)(c) - DecryptionKey);
                DecryptedText += newCharacter.ToString();
            }

            return DecryptedText;
        }
        static public void Main(string[] args) {

            const int EncryptionKey = 2;

            string Txt = ReadString("Please enter a text ? ");
            string EncryptedText = Encrypt(Txt, EncryptionKey);
            string DecryptedText = Decrypt(EncryptedText, EncryptionKey);

            Console.WriteLine("Text Before Encryption : " + Txt);
            Console.WriteLine("Text After Encryption  : " + EncryptedText);
            Console.WriteLine("Text After Decryption  : " + DecryptedText);
            Console.ReadKey();
        }

    }
}
