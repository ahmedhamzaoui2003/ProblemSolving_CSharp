using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_15
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

        static private stDate IncreaseDateByOneDay(stDate date)
        {
            if (IsLastDayInMonth(date))
            {
                date.day = 1;
                if (IsLastMonthInYear(date))
                {
                    date.month = 1;
                    date.year++;
                }
                else
                    date.month++;
            }else
                date.day++;

            return date;

        }
        

        static private bool IsLastMonthInYear(stDate date)
        {
            return date.month == 12;
        }
        static void Main(string[] args)
        {
            stDate date;
            date.day = 30;
            date.month = 11;
            date.year = 2022;

            date = IncreaseDateByOneDay(date);
            Console.WriteLine($"Date after adding one day is :{date.day}/{date.month}/{date.year}");


        }


    }
}
