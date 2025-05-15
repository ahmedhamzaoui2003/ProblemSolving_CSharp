using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P12__Number_Pattern_
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

        static public void NumberPattern(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            int num = ReadNumber("Please enter a number ? ");
            NumberPattern(num);
            Console.ReadLine();

        }
    }
}
