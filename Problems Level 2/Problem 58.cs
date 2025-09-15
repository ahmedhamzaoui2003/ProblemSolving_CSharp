using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_58
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

        static private bool IsTwoPeriodsOverlapped(stPeriod p1,stPeriod p2)
        {
            return !(CompareTwoDates(p1.EndDate, p2.StartDate) == enCompareDate.Before || CompareTwoDates(p2.EndDate, p1 .StartDate) == enCompareDate.Before);
        }

        static void Main(string[] args)
        {
            stPeriod p1, p2;
            
            p1.StartDate.day = 1;
            p1.StartDate.month = 2;
            p1.StartDate.year = 2022;

            p1.EndDate.day = 10;
            p1.EndDate.month = 2;
            p1.EndDate.year = 2022;


            p2.StartDate.day = 5;
            p2.StartDate.month = 2;
            p2.StartDate.year = 2022;

            p2.EndDate.day = 15;
            p2.EndDate.month = 2;
            p2.EndDate.year = 2022;

            Console.WriteLine(IsTwoPeriodsOverlapped(p1, p2) ? "\nYes , Periods Overlap." : "\nNo, Periods don't overlap.");
           
        }

    }
}
