using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P15__Guess_a_3_Letter_Password_
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
        static public string ReadString(string message) { 
            Console.WriteLine(message);
            string str = Console.ReadLine();
            return str;
        }
        static public bool Guess3LetterPassword(string psw)
        {
            int Trials = 0;
            string word = "";
            for (char first = 'A'; first <= 'Z'; first++)
            {
                for (char second = 'A'; second <= 'Z'; second++)
                {
                    for (char third = 'A'; third <= 'Z'; third++)
                    {
                        /*word = $"{first}{second}{third}";*/
                        word += first.ToString() + second.ToString() + third.ToString();
                        Console.WriteLine($"Trial[{++Trials}] : {word}");
                        if (psw == word)
                        {
                            Console.WriteLine("\nPassword is " + word);
                            Console.WriteLine($"Found after {Trials} Trial(s)");
                            return true;
                        }
                        word = "";
                    }
                }
            }
            Console.WriteLine($"\a\nPassword {psw} was not found :-(");
            return false;
        }


        static public void Main(string[] args)
        {
            Guess3LetterPassword(ReadString("Enter a Password ?"));
            Console.ReadLine();
        }
    }
}
