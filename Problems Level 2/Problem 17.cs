using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_17
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

        static private bool IsDate1EqualsDate2(stDate date1, stDate date2)
        {
            //return date1.year == date2.year && date1.month == date2.month && date1.day == date2.day;
            return (date1.year == date2.year ? (date1.month == date2.month ? (date1.day == date2.day ? true : false) : false) : false);
        }

        static private int DifferenceBetweenTwoDates(stDate date1, stDate date2, int IncludeEndDay = 0)
        {
            int DiffInDays = 0;
            while (true)
            {
                if (IsDate1EqualsDate2(date1, date2))
                    return DiffInDays + IncludeEndDay;

                date1 = IncreaseDateByOneDay(date1);
                DiffInDays++;
            }
        }


        // Get the current date : 
        static private stDate GetCurrentDate(){
            // Get the current date and time
            DateTime now = DateTime.Now;

            stDate date;
            date.day = now.Day;
            date.month = now.Month;
            date.year = now.Year;

            return date;
        }

        static void Main(string[] args)
        {
            stDate BirthDay, CurrentDate;
            
            BirthDay.day = 2;
            BirthDay.month = 11;
            BirthDay.year = 2003;

            CurrentDate = GetCurrentDate();

            Console.WriteLine($"Your Birth Day is : {BirthDay.day}/{BirthDay.month}/{BirthDay.year}");
            Console.WriteLine($"Current Date is : {CurrentDate.day}/{CurrentDate.month}/{CurrentDate.year}");
            Console.WriteLine($"Your Age is : {DifferenceBetweenTwoDates(BirthDay, CurrentDate)} Day(s).");




        }




    }
}
