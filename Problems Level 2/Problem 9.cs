using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_9
    {

        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static private int NumberOfDays(int year, int month)
        {
            int[] arrDays = { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return arrDays[month - 1];
        }

        static private int DaysFromTheBeginningOfTheYear(int year, int month ,int day)
        {
            // you can do a ternary operator in an array initalization as i did in the next line

            int totalDays = 0;
            for (int i = 1; i < month; i++)
                totalDays += NumberOfDays(year, i);

            return totalDays + day;

        }

        static void Main(string[] args)
        {
        
            Console.Write("Please enter a day ?");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a month ?");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a year ?");
            int year = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine($"\nNumber of days from the beginning of the year is {DaysFromTheBeginningOfTheYear(year, month, day)} days.");

        }

    }
}
