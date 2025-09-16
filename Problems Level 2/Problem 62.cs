using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_62
    {
        private struct stDate
        {
            public int day;
            public int month;
            public int year;
        }
        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        static private int NumberOfDaysInMonth(int year, int month)
        {
            List<int> daysInMonth = new List<int> { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysInMonth[month - 1];
        }

        static private bool IsValidDate(stDate date)
        {
            return date.day >= 1 && date.day <= NumberOfDaysInMonth(date.year, date.month) && date.month >= 1 && date.month <= 12 && date.year >= 1;
        }

        static void Main(string[] args)
        {
            stDate date;

            date.day = 25;
            date.month = 5;
            date.year = 2022;

            Console.WriteLine(IsValidDate(date) ? "\nYes , Date is a valide date." : "\nNo , Date is a not valide date.");
        }

    }
}
