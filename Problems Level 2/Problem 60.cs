using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_60
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

        static bool IsDateWithinPeriod(stPeriod p , stDate date)
        {
            return !(CompareTwoDates(date, p.StartDate) == enCompareDate.Before || CompareTwoDates(date,p.EndDate) == enCompareDate.After);
        }

        static void Main(string[] args)
        {
            stPeriod p1;

            p1.StartDate.day = 1;
            p1.StartDate.month = 1;
            p1.StartDate.year = 2022;

            p1.EndDate.day = 10;
            p1.EndDate.month = 1;
            p1.EndDate.year = 2022;

            // specific date : 
            stDate date;
            date.day = 22;
            date.month = 1;
            date.year = 2022;

            Console.WriteLine(IsDateWithinPeriod(p1, date) ? "\nYes , date is within period" : "\nNo , date is not within period");

        }


    }
}
