using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
    internal class P18___Random_characters__
    {

        static public char GenerateRandomCharacter(enRandomCharacter C)
        {
            var random = new Random();
            switch (C)
            {
                case enRandomCharacter.eCapital:
                    return (char)random.Next(65, 90);
               
                case enRandomCharacter.eSmall:
                    return (char)random.Next(97, 122);
               
                case enRandomCharacter.eSpecial:
                    return (char)random.Next(32, 47);
                
                case enRandomCharacter.eDigit:
                    return (char)random.Next(48, 57);
                
                default:
                    return'!';
            }

            }

        static public void Main(string[] args)
        {
            Console.WriteLine(GenerateRandomCharacter(enRandomCharacter.eSmall));
            Console.WriteLine(GenerateRandomCharacter(enRandomCharacter.eCapital));
            Console.WriteLine(GenerateRandomCharacter(enRandomCharacter.eSpecial));
            Console.WriteLine(GenerateRandomCharacter(enRandomCharacter.eDigit));

            Console.ReadLine();
        }
    }
}
