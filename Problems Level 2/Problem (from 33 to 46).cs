using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem__from_33_to_46_
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
        static private stDate DecreaseDateByOneDay(stDate date)
        {
            if (date.day == 1)
            {
                if (date.month == 1)
                {
                    date.year--;
                    date.month = 12;
                    date.day = 31;
                }
                else
                {
                    date.month--;
                    date.day = NumberOfDaysInMonth(date.year, date.month);
                }
            }
            else
                date.day--;

            return date;

        }

        static private stDate DecreaseDateByXDays(stDate date, int xDays)
        {
            for(int i =1; i<= xDays; i++){
                date = DecreaseDateByOneDay(date);
            }
            return date;
        }

        static private stDate DecreaseDateByOneWeek(stDate date)
        {
            for(int i = 1; i <= 7; i++)
            {
                date = DecreaseDateByOneDay(date);
            }
            return date;
        }


        private static void Main(string[] args)
        {
            stDate date;
            date.day = 31;
            date.month = 12;
            date.year = 2022;


            Console.WriteLine("Date After :\n");
            
            date = DecreaseDateByOneDay(date);
            Console.WriteLine($"01- Substracting one day is  : {date.day}/{date.month}/{date.year}");

            date = DecreaseDateByXDays(date,10);
            Console.WriteLine($"02- Substracting 10 day is  : {date.day}/{date.month}/{date.year}");

            date = DecreaseDateByOneWeek(date);
            Console.WriteLine($"03- Substracting one week is  : {date.day}/{date.month}/{date.year}");




        }

    }
}
