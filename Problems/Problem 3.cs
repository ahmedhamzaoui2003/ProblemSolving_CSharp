using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_3
    {

        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static private int NumberOfDays(int year)
        {
            return IsLeapYear(year) ? 366 : 365;
        }

        static private int NumberOfHours(int year)
        {
            return NumberOfDays(year) * 24;
        }

        static private int NumberOfMinutes(int year)
        {
            return NumberOfHours(year) * 60;
        }

        static private int NumberOfSeconds(int year)
        {
            return NumberOfMinutes(year) * 60;
        }


        static void Main(string[] args)
        {

            Console.Write("Please enter the year to check ? ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Number of Days      in Year [{year}] is {NumberOfDays(year)}");
            Console.WriteLine($"Number of Hours     in Year [{year}] is {NumberOfHours(year)}");
            Console.WriteLine($"Number of Minutes   in Year [{year}] is {NumberOfMinutes(year)}");
            Console.WriteLine($"Number of Seconds   in Year [{year}] is {NumberOfSeconds(year)}");

        }


    }
}
