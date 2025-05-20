using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_10
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

        static private int NumberOfDays(int year, int month)
        {
            int[] arrDays = { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return arrDays[month - 1];
        }

        static private int DaysFromTheBeginningOfTheYear(int year, int month, int day)
        {
            // you can do a ternary operator in an array initalization as i did in the next line

            int totalDays = 0;
            for (int i = 1; i < month; i++)
                totalDays += NumberOfDays(year, i);

            return totalDays + day;

        }


        static private stDate GoBackToDate(int totalDays , int year)
        {
            stDate date;
            date.day = 0;
            date.month = 0;
            date.year = year;

            int numberOfDays = 0;
            for (int i = 1; i <= 12; i++)
            {
                
                if(totalDays - numberOfDays < NumberOfDays(year,i) )
                {
                    date.day = totalDays - numberOfDays;
                    date.month += 1;
                    break;
                }
                else
                {
                    numberOfDays += NumberOfDays(year, i);
                    date.month = i;
                } 
                
            }
            return date;

        }

        //other method (more optimized and faster)

        static private stDate GetDateFromDayOrderInYear(int DateOrderInYear,int year)
        {
            stDate date;
            int RemaningDays = DateOrderInYear;
            int MonthDays = 0;


            date.year = year;
            date.month = 1;

            while (true)
            {
                MonthDays = NumberOfDays(year, date.month);
                if(RemaningDays > MonthDays)
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



        static void Main(string[] args)
        {

            int numberOfDays = DaysFromTheBeginningOfTheYear(2022, 9, 20);
            Console.WriteLine($"Number of days from the beginning of the year is : {numberOfDays}");

            stDate date = GetDateFromDayOrderInYear(numberOfDays, 2022);
            Console.WriteLine($"Date for [{numberOfDays}] is : {date.day}/{date.month}/{date.year}");

        }
    }
}
