using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P13_Inverted_letter_pattern__
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
        static public void InvertedLetterPattern(int num)
        {
            for (int i = num; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(64 +i));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = ReadNumber("Please enter a number ? ");
            InvertedLetterPattern(num);
            Console.ReadLine();
        }


    }
}
