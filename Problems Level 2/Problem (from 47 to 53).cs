using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem__from_47_to_53_
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

        static private bool IsDate1BeforeThanDate2(stDate date1, stDate date2)
        {
            return date1.year < date2.year ? true : (date1.year == date2.year ? date1.month < date2.month ? true : date1.month == date2.month ? (date1.day < date2.day ? true : false) : false : false);
        }


        static private bool IsDate1EqualsDate2(stDate date1, stDate date2)
        {
            //return date1.year == date2.year && date1.month == date2.month && date1.day == date2.day;
            return (date1.year == date2.year ? (date1.month == date2.month ? (date1.day == date2.day ? true : false) : false) : false);
        }

        static private bool IsLastDayInMonth(stDate date)
        {
            return date.day == NumberOfDaysInMonth(date.year, date.month);
        }

        static private bool IsLastMonthInYear(stDate date)
        {
            return date.month == 12;
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
            }
            else
                date.day++;

            return date;

        }

        static private void Swap(ref stDate date1, ref stDate date2)
        {
            stDate temp = date1;
            date1 = date2;
            date2 = temp;
        }
        static private int GetDifferenceInDays(stDate date1, stDate date2, bool IncludeEndDay = false)
        {
            int Days = 0;
            short SwapFlagValue = 1;

            if (!IsDate1BeforeThanDate2(date1, date2))
            {
                Swap(ref date1, ref date2);
                SwapFlagValue = -1;
            }

            while (IsDate1BeforeThanDate2(date1, date2))
            {
                Days++;
                date1 = IncreaseDateByOneDay(date1);
            }
            return IncludeEndDay ? Days * SwapFlagValue + 1 : Days * SwapFlagValue;

        }

        static private int GetDayOrder(int year, int month, int day)
        {
            int a, y, m, d;
            a = (14 - month) / 12;
            y = year - a;
            m = month + (12 * a) - 2;
            // the index of day in the week : (gregorian calendar)
            d = (day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;

            return d;
        }


        static private string GetDayName(int dayOrder)
        {
            string[] DayNames = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            return DayNames[dayOrder];
        }


        // Overload the GetDayOrder to take date stucture : 

        static private int GetDayOrder(stDate date)
        {
            return GetDayOrder(date.year, date.month, date.day);
        }

        static private bool IsEndOfWeek(stDate date)
        {

            return GetDayOrder(date) == 6;
        }


        static private bool IsWeekEnd(stDate date)
        {
            return GetDayOrder(date) == 5 || GetDayOrder(date) == 6;
        }


        static private bool IsBusinessDay(stDate date)
        {
            return !IsWeekEnd(date);
        }


        static private int DaysUntilTheEndOfWeek(stDate date)
        {
            return 6 - GetDayOrder(date);
        }

        static private int DaysUntilTheEndOfMonth(stDate date)
        {
            stDate date2;
            date2.year = date.year;
            date2.month = date.month;
            date2.day = NumberOfDaysInMonth(date.year,date.month);

            return GetDifferenceInDays(date, date2, true);
        }

        static private int DaysUntilTheEndOfYear(stDate date)
        {
            stDate date2;
            date2.year = date.year;
            date2.month = 12;
            date2.day = 31;

            return GetDifferenceInDays(date, date2, true);
        }





        static void Main(string[] args)
        {
            stDate date;
            DateTime now = DateTime.Now; 
            
            date.year = 2022;
            date.month = 9;
            date.day = 23;
            
            int dayOrder = GetDayOrder(date);
            Console.WriteLine($"Today is {GetDayName(dayOrder)} , {date.day}/{date.month}/{date.year}");

            Console.WriteLine("\nIs it End of Week ?");
            Console.WriteLine(IsEndOfWeek(date) ? "Yes it is Saturday ! end of week." : "No Not end of week.");

            Console.WriteLine("\nIs it Weekend ?");
            Console.WriteLine(IsWeekEnd(date) ? "Yes it is a week end." : "No Not week end.");

            Console.WriteLine("\nIs it Business Day ?");
            Console.WriteLine(IsBusinessDay(date) ? "Yes it is Business Day." : "No it is Not a Business Day.");

            Console.WriteLine($"\nDays until end of week : {DaysUntilTheEndOfWeek(date)} Day(s).");
            Console.WriteLine($"Days until end of month : {DaysUntilTheEndOfMonth(date)} Day(s).");
            Console.WriteLine($"Days until end of year : {DaysUntilTheEndOfYear(date)} Day(s).");


        }


    }
}
