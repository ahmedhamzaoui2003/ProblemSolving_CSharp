using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_55
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
        static private stDate CalculateTheVacationEnd(stDate VacationDate , int VacationDays)
        {
            while(VacationDays >= 0)
            {
                VacationDate = IncreaseDateByOneDay(VacationDate);
                if (IsBusinessDay(VacationDate))
                    VacationDays--;
            }
            return VacationDate;
        }

        static void Main(string[] args)
        {
            stDate VacationStart, VacationEnd;
            VacationStart.day = 1;
            VacationStart.month = 1;
            VacationStart.year = 2022;

            

            Console.WriteLine($"\nVacation From : {GetDayName(GetDayOrder(VacationStart))} , {VacationStart.day}/{VacationStart.month}/{VacationStart.year}");

            Console.Write("\nPlease enter vacation days ?");
            int vacationDays = Convert.ToInt32(Console.ReadLine());

            VacationEnd = CalculateTheVacationEnd(VacationStart, vacationDays);

            Console.WriteLine($"\nVacation To   : {GetDayName(GetDayOrder(VacationEnd))} , {VacationEnd.day}/{VacationEnd.month}/{VacationEnd.year}");
        }
    }
}
