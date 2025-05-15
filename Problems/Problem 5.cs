using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems
{
    internal class Problem_5
    {
        static private int ReadValidMonth()
        {
            int month;
            do
            {
                Console.Write("Please enter a month to check ?");
                month = Convert.ToInt32(Console.ReadLine());

            } while (month < 1 || month > 12);
            return month;
        }

        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static private int NumberOfDaysInMonth(int year, int month)
        {
            List<int> daysInMonth = new List<int> {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return IsLeapYear(year) && (month == 2) ? 29 : daysInMonth[month - 1];
            //return month == 2 ? (IsLeapYear(year) ? 29 : 28) : daysInMonth[month-1];
        }


        static void Main(string[] args)
        {
            Console.Write("Please enter the year to check ? ");
            int year = Convert.ToInt32(Console.ReadLine());

            int month = ReadValidMonth();
            Console.WriteLine($"\nNumber of Days in Month [{month}] is {NumberOfDaysInMonth(year, month)}");
        }



    }
}
