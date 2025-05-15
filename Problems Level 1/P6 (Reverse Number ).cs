using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P6__Reverse_Number__
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

        static public int ReverseNumber(int num) {

            // algorithm :
            int reversedNumber = 0,remainder = 0;
            while(num > 0)
            {
                remainder = num % 10;
                num /= 10;
                reversedNumber = reversedNumber * 10 + remainder;
            }
            return reversedNumber;
        }

        static void Main(string[] args) {

            Console.WriteLine("After reversing the number = " + ReverseNumber(ReadNumber()));
            Console.ReadLine();


        }
    }
}
