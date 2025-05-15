using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    enum enRandomCharacter
    {
        eCapital = 1,
        eSmall = 2,
        eSpecial = 3,
        eDigit = 4
    }

    internal class P19__Generate_Keys_
    {
        // Random Number :  Declare Random as a class-level static field
        private static Random random = new Random();

        static int RandomNumber(int from , int to)
        {
            return random.Next(from, to  +1);
        }
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

        static public char GenerateRandomCharacter(enRandomCharacter C)
        {
            
            switch (C)
            {
                case enRandomCharacter.eCapital:
                    return (char)RandomNumber(65, 90);

                case enRandomCharacter.eSmall:
                    return (char)RandomNumber(97, 122);

                case enRandomCharacter.eSpecial:
                    return (char)RandomNumber(32, 47);

                case enRandomCharacter.eDigit:
                    return (char)RandomNumber(48, 57);

                default:
                    return '!';
            }
        }

        static public string GenerateWord(enRandomCharacter C,byte length)
        {
            string word = "";

            for(int i = 1;i<=length;i++)
                word += GenerateRandomCharacter(C);
            

            return word;
        }

        static public string GenerateOneKey()
        {
            string key = "";

            key += GenerateWord(enRandomCharacter.eCapital,4) + "-";
            key += GenerateWord(enRandomCharacter.eCapital,4) + "-";
            key += GenerateWord(enRandomCharacter.eCapital,4) + "-";
            key += GenerateWord(enRandomCharacter.eCapital,4);

            return key;
        }

        static public void GenerateKeys(int Count)
        {
            for(int i = 1; i <= Count; i++)
            {
                Console.WriteLine($"Key[{i}] : {GenerateOneKey()}");
            }
        }
       
        
        static public void Main(string[] args)
        {

            GenerateKeys(ReadNumber("Please enter the number of keys ? "));
           Console.ReadLine();
        }
    }

}
