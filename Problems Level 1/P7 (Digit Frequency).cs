using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P7__Digit_Frequency_
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

        static public int DigitFrequency(int num,int digitToCount)
        {
            int Frequency = 0;
            string strNumber = Convert.ToString(num);
            foreach(char c in strNumber)
            {
                if (c == digitToCount.ToString()[0]) Frequency++;
               
                /*
                    digitToCount.ToString()[0] converts the integer digitToCount to a string 
                    and then takes the first character of that string.
                    For example, if digitToCount is 2, this will give you the character '2'.
                */
                   
            }
            return  Frequency; 
            
        }
        // other method : 
        static public int DigitFrequency2(int num, int digitToCount)
        {
           int Frequency =0 , Remainder = 0;
            while(num > 0)
            {
                Remainder = num % 10;
                num /= 10;
                if(Remainder == digitToCount)
                    Frequency++;
            }
            return Frequency;

        }


        static void Main(string[] args)
        {
            int num = ReadNumber("Please enter a number ? ");
            int digitToCount = ReadNumber("Enter the digit to count ?");
            Console.WriteLine($"Digit {digitToCount} Frequency is {DigitFrequency2(num, digitToCount)} Time(s).");
            Console.ReadLine();
        }


    }
}
