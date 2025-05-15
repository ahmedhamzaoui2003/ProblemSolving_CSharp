using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P14_All_Word_From_AAA_to_ZZZ_
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

        static public void PrintAllWordsFromAAAToZZZ()
        {
            for(int i = 65; i <= 90; i++)
            {
                for(int j = 65; j <= 90; j++)
                {
                    for(int k = 65; k <= 90; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }

        // other method (Loop with characters ) : 
        static public void AllWordsFromAAAToZZZ()
        {
            for (char first = 'A'; first<='Z'; first++)
            {
                for (char second = 'A'; second <= 'Z'; second++)
                {
                    for (char third = 'A'; third <= 'Z'; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
        static public void Main(string[] args) {

            AllWordsFromAAAToZZZ();
            Console.ReadLine();


        }
    }
}
