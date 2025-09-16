using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_61
    {
        private struct stDate
        {
            public int day;
            public int month;
            public int year;
        }
        private struct stPeriod
        {
            public stDate StartDate;
            public stDate EndDate;
        }
        private enum enCompareDate
        {
            Before = -1,
            Equal = 0,
            After = 1
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

        static private bool IsDate1AfterDate2(stDate date1, stDate date2)
        {
            return !IsDate1BeforeThanDate2(date1, date2) && !IsDate1EqualsDate2(date1, date2);
        }

        static private enCompareDate CompareTwoDates(stDate date1, stDate date2)
        {
            if (IsDate1BeforeThanDate2(date1, date2))
                return enCompareDate.Before;
            else if (IsDate1EqualsDate2(date1, date2))
                return enCompareDate.Equal;

            return enCompareDate.After;
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

        static private bool IsTwoPeriodsOverlapped(stPeriod p1, stPeriod p2)
        {
            return !(CompareTwoDates(p1.EndDate, p2.StartDate) == enCompareDate.Before || CompareTwoDates(p2.EndDate, p1.StartDate) == enCompareDate.Before);
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

        static private int DifferenceBetweenTwoDates(stDate date1, stDate date2, bool IncludeEndDay = false)
        {
            int Days = 0;
            while (IsDate1BeforeThanDate2(date1, date2))
            {
                Days++;
                date1 = IncreaseDateByOneDay(date1);
            }
            return IncludeEndDay ? ++Days : Days;

        }
        static private int CalculatePeriodLength(stPeriod p, bool IncludeEndDate = false)
        {
            return DifferenceBetweenTwoDates(p.StartDate, p.EndDate, IncludeEndDate);
        }
        static bool IsDateWithinPeriod(stPeriod p, stDate date)
        {
            return !(CompareTwoDates(date, p.StartDate) == enCompareDate.Before || CompareTwoDates(date, p.EndDate) == enCompareDate.After);
        }

        static int CountOverlapDays(stPeriod p1, stPeriod p2)
        {
            if (!IsTwoPeriodsOverlapped(p1, p2)) 
                return 0;

            if(IsDateWithinPeriod(p1,p2.StartDate) && IsDateWithinPeriod(p1,p2.EndDate))
                    return CalculatePeriodLength(p2);

            
            if(IsDateWithinPeriod(p2,p1.StartDate) && IsDateWithinPeriod(p2, p1.EndDate))
                    return CalculatePeriodLength(p1);

            if (IsDateWithinPeriod(p1, p2.StartDate) && IsDateWithinPeriod(p2, p1.EndDate))
                return DifferenceBetweenTwoDates(p2.StartDate, p1.EndDate);

            else if (IsDateWithinPeriod(p2, p1.StartDate) && IsDateWithinPeriod(p1, p2.EndDate))
                return DifferenceBetweenTwoDates(p1.StartDate, p2.EndDate);

            else return 1;

        }

        static void Main(string[] args)
        {
            stPeriod p1,p2;

            p1.StartDate.day = 1;
            p1.StartDate.month = 1;
            p1.StartDate.year = 2022;

            p1.EndDate.day = 10;
            p1.EndDate.month = 1;
            p1.EndDate.year = 2022;

            p2.StartDate.day = 5;
            p2.StartDate.month = 1;
            p2.StartDate.year = 2022;

            p2.EndDate.day = 31;
            p2.EndDate.month = 1;
            p2.EndDate.year = 2022;

            Console.WriteLine("\nOverlap Days Count is : " + CountOverlapDays(p1,p2));

        }

    }
}
