using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems
{
    internal class Problem_4
    {
        // Problem 3 : Print the number of Days , Hours , Minutes and Seconds in a certain Month :

        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        static private int ReadValidMonth()
        {
            int month;
            do
            {
                Console.Write("Please enter a month to check ?");
                month = Convert.ToInt32(Console.ReadLine());

            }while (month < 1 || month > 12);
            return month;
        }

        static private int Months(int month)
        {
            List<int> daysInMonth = new List<int> { int.MaxValue, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysInMonth[month];
        }

        static private int NumberOfDaysInMonth(int year,int month)
        {
            return IsLeapYear(year)  && (month == 2) ? 29 : Months(month);
        }
        static private int NumberOfHoursInMonth(int year, int month)
        {
            return NumberOfDaysInMonth(year,month) * 24;
        }
        static private int NumberOfMinutesInMonth(int year, int month)
        {
            return NumberOfHoursInMonth(year,month) * 60;
        }
        static private int NumberOfSecondsInMonth(int year, int month)
        {
            return NumberOfMinutesInMonth(year,month) * 60;
        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the year to check ? ");
            int year = Convert.ToInt32(Console.ReadLine()); 

            int month = ReadValidMonth();

            Console.WriteLine($"\nNumber of Days    in Month [{month}] is {NumberOfDaysInMonth(year, month)}");
            Console.WriteLine($"Number of Hours   in Month [{month}] is {NumberOfHoursInMonth(year, month)}");
            Console.WriteLine($"Number of Minutes in Month [{month}] is {NumberOfMinutesInMonth(year, month)}");
            Console.WriteLine($"Number of Seconds in Month [{month}] is {NumberOfSecondsInMonth(year, month)}");

        }
    }
}
