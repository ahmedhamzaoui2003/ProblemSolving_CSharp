using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_57
    {

        private struct stDate
        {
            public int day;
            public int month;
            public int year;
        }
        private enum enCompareDate
        {
            Before=-1,
            Equal=0,
            After=1
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

        static private enCompareDate CompareTwoDates(stDate date1,stDate date2)
        {
            if (IsDate1BeforeThanDate2(date1, date2))
                return enCompareDate.Before;
            else if (IsDate1EqualsDate2(date1, date2))
                return enCompareDate.Equal;
            
            return enCompareDate.After;
        }


        static void Main(string[] args)
        {
            stDate date1, date2;
            date1.day = 1;
            date1.month = 9;
            date1.year = 2000;

            date2.day = 1;
            date2.month = 9;
            date2.year = 2000;

            Console.WriteLine("Compare Result = " + (int)CompareTwoDates(date1,date2));

        }


    }
}
