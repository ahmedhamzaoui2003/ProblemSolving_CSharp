using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P5__Sum_Of_Digits_
    {
        static public int ReadNumber()
        {
            int num;
            do
            {
                Console.WriteLine("Please enter a number ?");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num <= 0);

            return num;

        }
        static public int SumOfDigits(int num)
        {
            int remain = 0 , SumOfDigits = 0;

            while (num > 0)
            {
                remain = num % 10;
                num /= 10;
                SumOfDigits += remain;
            }
            return SumOfDigits;
        }
        static void Main(String[] arg)
        {
            Console.WriteLine("The Sum Of Digits  = " + SumOfDigits(ReadNumber()));
            Console.ReadLine();

        }

    }
}
