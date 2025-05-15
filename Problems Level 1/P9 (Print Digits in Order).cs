using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P9__Print_Digits_in_Order_
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
        static public int ReverseNumber(int num)
        {

            // algorithm :
            int reversedNumber = 0, remainder = 0;
            while (num > 0)
            {
                remainder = num % 10;
                num /= 10;
                reversedNumber = reversedNumber * 10 + remainder;
            }
            return reversedNumber;
        }
        static public void PrintNumberInReversedOrder(int num)
        {
            int remain = 0;
            while (num > 0)
            {
                remain = num % 10;
                num /= 10;
                Console.WriteLine(remain);
            }
        }
        static public void PrintDigitsInOrder(int num)
        {
            // algorithm : we reverse the number and then we print it in a reversed order using the previous functions :
            PrintNumberInReversedOrder(ReverseNumber(num));

        }
        


        static void Main(string[] args)
        {

            int num = ReadNumber("Please enter a number ? ");
            PrintDigitsInOrder(num);
            Console.ReadLine();

        }
    }
}
