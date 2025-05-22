using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_14
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
        static private bool IsLastDayInMonth(stDate date)
        {
            return date.day == NumberOfDaysInMonth(date.year, date.month);
        }

        static private bool IsLastMonthInYear(stDate date)
        {
            return date.month == 12;
        }
        static void Main(string[] args)
        {
            stDate date1;
            date1.day = 31;
            date1.month = 12;
            date1.year = 2022;


            Console.WriteLine(IsLastDayInMonth(date1) ? "Yes, Day is Last Day in month" : "No, Day is not Last Day in month");
            Console.WriteLine(IsLastMonthInYear(date1) ? "Yes, Month is last month in year" : "No, Month is not last month in year");
        }
    }
}
