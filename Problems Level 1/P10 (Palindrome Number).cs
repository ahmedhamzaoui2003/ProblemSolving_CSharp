using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P10__Palindrome_Number_
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

        static public bool isPalindromeNumber(int num)
        {
            return num == ReverseNumber(num);
        }

        // other method witout using other previous functions : 
        static public bool isPalindromeNumber2(int num)
        {
            string str = num.ToString();    
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {

            int num = ReadNumber("Please enter a number ? ");
            Console.WriteLine((isPalindromeNumber2(num) ? num + " is Palindrome" : num + " is not Palindrome"));
            Console.ReadLine();

        }
    }
}
