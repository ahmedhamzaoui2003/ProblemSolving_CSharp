using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem__from_19_to_31_
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


        // Increase Date methods :
        static private stDate IncreaseDateByXDays(stDate date , int xDays)
        {
            for (int i = 1; i <= xDays ; i++)
            {
                date = IncreaseDateByOneDay(date);
            }
            return date;
        }
        static private stDate IncreaseDateByOneWeek(stDate date)
        {
            return IncreaseDateByXDays(date, 7);
        }
        static private stDate IncreaseDateByXWeeks(stDate date , int xWeeks)
        {
            for (int i = 1; i <= xWeeks; i++)
            {
                date = IncreaseDateByOneWeek(date);
            }
            return date;
        }
        static private stDate IncreaseDateByOneMonth(stDate date)
        {
            if (IsLastMonthInYear(date))
            {
                date.month = 1;
                date.year++;
            }
            else
                date.month++;


            // Adjust day if it exceeds the number of days in the new month
            if (date.day > NumberOfDaysInMonth(date.year , date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }
        static private stDate IncreaseDateByXMonths(stDate date, int xMonths)
        {
            for (int i = 1; i <= xMonths; i++)
            {
                date = IncreaseDateByOneMonth(date);
            }
            return date;
        }
        static private stDate IncreaseDateByOneYear(stDate date)
        {
            date.year++;

            if (date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        static private stDate IncreaseDateByXYears(stDate date,int xYears)
        {
            for(int i =1;i<=xYears; i++)
            {
                date = IncreaseDateByOneYear(date);
            }

            return date;
        }

        static private stDate IncreaseDateByXYearsFaster(stDate date , int xYears)
        {
            date.year += xYears;

            if(date.month==2 && date.day > NumberOfDaysInMonth(date.year,date.month))
                date.day = NumberOfDaysInMonth(date.year, date.month);

            return date;
        }


        static void Main(string[] args)
        {

            stDate date;
            date.day = 31;
            date.month = 12;
            date.year = 2022;

           
            Console.WriteLine("Date After :\n");
            date = IncreaseDateByOneDay(date);
            Console.WriteLine($"01- Adding one day is    : {date.day}/{date.month}/{date.year}");
            
            date = IncreaseDateByXDays(date, 10);
            Console.WriteLine($"02- Adding 10 days is    : {date.day}/{date.month}/{date.year}");
            
            date = IncreaseDateByOneWeek(date);
            Console.WriteLine($"03- Adding one week is   : {date.day}/{date.month}/{date.year}");
            
            date = IncreaseDateByXWeeks(date,10);
            Console.WriteLine($"04- Adding 10 weeks is   : {date.day}/{date.month}/{date.year}");

            date = IncreaseDateByOneMonth(date);
            Console.WriteLine($"05- Adding one month is   : {date.day}/{date.month}/{date.year}");
            
            date = IncreaseDateByXMonths(date,5);
            Console.WriteLine($"06- Adding 5 months is   : {date.day}/{date.month}/{date.year}");

            date = IncreaseDateByOneYear(date);
            Console.WriteLine($"07- Adding one year is   : {date.day}/{date.month}/{date.year}");

            date = IncreaseDateByXYears(date, 10);
            Console.WriteLine($"08- Adding 10 Years is   : {date.day}/{date.month}/{date.year}");

            date = IncreaseDateByXYearsFaster(date, 10);
            Console.WriteLine($"09- Adding 10 Years (Faster) is   : {date.day}/{date.month}/{date.year}");


        }



    }
}
