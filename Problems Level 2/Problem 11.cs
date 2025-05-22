using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_11
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
            int[] arrDays = { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return arrDays[month - 1];
        }
        static private int NumberOfDaysInYear(int year)
        {
            return IsLeapYear(year) ? 366 : 365;
        }

        static private stDate GetDateFromDayOrderInYear(int DateOrderInYear, int year)
        {
            stDate date;
            int RemaningDays = DateOrderInYear;
            int MonthDays = 0;


            date.year = year;
            date.month = 1;

            while (true)
            {
                MonthDays = NumberOfDaysInMonth(year, date.month);
                if (RemaningDays > MonthDays)
                {
                    RemaningDays -= MonthDays;
                    date.month++;
                }
                else
                {
                    date.day = RemaningDays;
                    break;
                }
            }
            return date;
        }
        static private int DaysFromTheBeginningOfTheYear(int year, int month, int day)
        {
            // you can do a ternary operator in an array initalization as i did in the next line

            int totalDays = 0;
            for (int i = 1; i < month; i++)
                totalDays += NumberOfDaysInMonth(year, i);

            return totalDays + day;

        }
        static private stDate AddDaysToDate(int DaysToAdd , stDate date)
        {

            int DaysInYear = 0;
            // this is the trick to get the number of days from the beginning of the year
            int RemaningDays = DaysToAdd + DaysFromTheBeginningOfTheYear(date.year, date.month, date.day);

            while (true)
            {
                DaysInYear = NumberOfDaysInYear(date.year);
                if(RemaningDays >= DaysInYear)
                {
                    RemaningDays -= DaysInYear;
                    date.year++;
                }
                else
                {
                    date = GetDateFromDayOrderInYear(RemaningDays, date.year);
                    break;
                }
            }
            return date;
        }

        // other method : 
        
        static private stDate AddDaysToDate2(int DayToAdd,stDate date)
        {
            int RemaningDays = DayToAdd + DaysFromTheBeginningOfTheYear(date.year, date.month, date.day);
            date.month = 1;

            int MonthDays = 0;
            while (true)
            {
                MonthDays = NumberOfDaysInMonth(date.year, date.month);
                if(RemaningDays > MonthDays)
                {
                    RemaningDays -= MonthDays;
                    date.month++;

                    // for the last month of the year :
                    if (date.month > 12)
                    {
                        date.year++;
                        date.month = 1;
                    }
                }
                else
                {
                    date.day = RemaningDays;
                    break;
                }
                


            }
            return date;
        }
        


        static void Main(string[] args)
        {
            stDate date;
            date.day = 10;
            date.month = 10;
            date.year = 2022;
            int DaysToAdd = 2500;
            stDate newDate = AddDaysToDate2(DaysToAdd, date);
            Console.WriteLine($"Current Date is : {date.day}/{date.month}/{date.year}");
            Console.WriteLine($"New Date after adding [{DaysToAdd}] days is : {newDate.day}/{newDate.month}/{newDate.year}");
        }


    }
}
