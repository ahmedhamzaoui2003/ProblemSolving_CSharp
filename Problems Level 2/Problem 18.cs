using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_18
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
        static private bool IsDate1BeforeThanDate2(stDate date1, stDate date2)
        {
            return date1.year < date2.year ? true : (date1.year == date2.year ? date1.month < date2.month ? true : date1.month == date2.month ? (date1.day < date2.day ? true : false) : false : false);
        }


        // method : ka3ba le (ma3jebtnich el fekra mte3)
        static private int DifferenceInDays(stDate date1, stDate date2, bool IncludeEndDay = false)
        {
            int DiffInDays = 0;
            if(IsDate1BeforeThanDate2(date1, date2))
            {
                while (IsDate1BeforeThanDate2(date1, date2))
                {
                    date1 = IncreaseDateByOneDay(date1);
                    DiffInDays++;
                }
                return IncludeEndDay ? DiffInDays + 1 : DiffInDays;

            }
            else
            {
                while (IsDate1BeforeThanDate2(date2, date1))
                {
                    date2 = IncreaseDateByOneDay(date2);
                    DiffInDays--;
                }
                return IncludeEndDay ? DiffInDays -1 : DiffInDays;
            }
        }

        // other method (more efficient and optimized)
        static private void Swap(ref stDate date1, ref stDate date2)
        {
            stDate temp = date1;
            date1 = date2;
            date2 = temp;
        }
        static private int GetDifferenceInDays(stDate date1, stDate date2 , bool IncludeEndDay = false)
        {
            int Days = 0;
            short SwapFlagValue = 1;

            if (!IsDate1BeforeThanDate2(date1, date2))
            {
                Swap(ref date1, ref date2);
                SwapFlagValue = -1;
            }

            while(IsDate1BeforeThanDate2(date1, date2))
            {
                Days++;
                date1 = IncreaseDateByOneDay(date1);
            }
            return IncludeEndDay ? Days * SwapFlagValue + 1 : Days * SwapFlagValue;

        }


        static void Main(string[] args)
        {
            stDate date1, date2;
            date2.day = 1;
            date2.month = 1;
            date2.year = 2000;


            date1.day = 1;
            date1.month = 1;
            date1.year = 2022;

            Console.WriteLine($"Difference is : {GetDifferenceInDays(date1, date2)} Day(s).");
            Console.WriteLine($"Difference (Including End Day) is : {GetDifferenceInDays(date1, date2, true)} Day(s).");




        }
    }
}
