using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    // in this file we will put the important methods of each problem :
    internal class SolutionLevel2
    {

        //Problem 1 : Convert Number to text in english using recursion
        static string NumberToText(UInt64 num)
        {

            string[] arr1 = { "", " One", " Two", " Three", " Four", " Five", " Six", " Seven", " Eight", " Nine", " Ten", " Eleven", " Twelve", " Thirteen", " Fourteen", " Fifteen", " Sixteen", " Seventeen", " Eighteen", " Nineteen" };
            string[] arr2 = { "", "", " Twenty", " Thirty", " Fourty", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };

            if (num == 0) return arr1[0];

            if (num >= 1 && num <= 19)
                return arr1[num] + NumberToText(num / 10);

            if (num >= 20 && num <= 99)
                return arr2[num / 10] + " " + NumberToText(num % 10);

            if (num >= 100 && num <= 199) return " One Hundred" + NumberToText(num % 100);
            if (num >= 200 && num <= 999) return arr1[num / 100] + " Hundreds" + NumberToText(num % 100) + " ";

            if (num >= 1000 && num <= 1999)
                return " One Thousand" + NumberToText(num % 1000);

            if (num >= 2000 && num <= 999999)
                return NumberToText(num / 1000) + " Thousands" + NumberToText(num % 1000) + " ";

            if (num >= 1000000 && num <= 1999999) return " One Million" + NumberToText(num % 1000000);

            if (num >= 2000000 && num <= 999999999) return NumberToText(num / 1000000) + " Millions" + NumberToText(num % 1000000) + " ";

            if (num >= 1000000000 && num <= 1999999999) return " One Billion" + NumberToText(num % 1000000000);
            else
                return NumberToText(num / 1000000000) + " Billions" + NumberToText(num % 1000000000) + " ";

        }



        //Problem 2 : Check if a year is leap year or not
        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }



        // Problem 3 : Print the number of Days , Hours , Minutes and Seconds in a certain Year :
        static private int NumberOfDaysInYear(int year)
        {
            return IsLeapYear(year) ? 366 : 365;
        }
        static private int NumberOfHours(int year)
        {
            return NumberOfDaysInYear(year) * 24;
        }
        static private int NumberOfMinutes(int year)
        {
            return NumberOfHours(year) * 60;
        }
        static private int NumberOfSeconds(int year)
        {
            return NumberOfMinutes(year) * 60;
        }


        // problem 4 : Print the number of Days , Hours , Minutes and Seconds in a certain Month :
        static private int NumberOfDaysInMonth1(int year ,int month)
        {
            if (month < 1 || month > 12)
                return 0;
            if (month == 2)
            {
                return IsLeapYear(year) ? 29 : 28;
            }
            List<int> arr31Days = new List<int> { 1, 3, 5, 7, 8, 10, 12 };
            for (short i = 1; i <= 7; i++)
            {
                if (arr31Days[i - 1] == month)
                    return 31;
            }
            //if you reach here then its 30 days.
            return 30;
        }

        static private int NumberOfHoursInMonth(int year, int month)
        {
            return NumberOfDaysInMonth1(year, month) * 24;
        }
        static private int NumberOfMinutesInMonth(int year, int month)
        {
            return NumberOfHoursInMonth(year, month) * 60;
        }
        static private int NumberOfSecondsInMonth(int year, int month)
        {
            return NumberOfMinutesInMonth(year, month) * 60;
        }

        // Problem 5 : check the number of days in month in 2 lines of code : 
        
        static private int NumberOfDaysInMonth(int year, int month)
        {
            List<int> daysInMonth = new List<int> { 31, (IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysInMonth[month - 1];
        }



        // Problem 6 : Get the day of week name of certain date (Gregorian Calendar): 
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

        // Problem 7 : Print the calendar of a certain month in a certain year

        static private string GetMonthDay(int month)
        {
            string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            return Months[month - 1];
        }

        static private void PrintCalendar(int year, int month)
        {
            Console.WriteLine($"\n  __________________{GetMonthDay(month)}___________________\n");
            Console.WriteLine("  Sun   Mon   Tue   Wed   Thu   Fri   Sat\n");

            int daysInMonth = NumberOfDaysInMonth(year, month);
            int dayOrder = GetDayOrder(year, month, 1);
            int counter = dayOrder;

            int i;
            for (i = 0; i < dayOrder; i++)
            {
                Console.Write("      ");
            }
            for (int j = 1; j <= daysInMonth; j++)
            {
                Console.Write($"  {j,3} ");// right align the number in 2 spaces

                //if((i + dayOrder) % 7 == 0) // print new line after 7 days
                if (++i % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"\n  ________________________________________\n");

        }



        // Problem 8 : Print the calendar of a certain year
        static private void PrintYearClendar(int year)
        {
            Console.WriteLine($"\n  ________________________________________\n");
            Console.WriteLine($"               Calendar - {year}              ");
            Console.WriteLine($"\n  ________________________________________\n");

            for (int i = 1; i <= 12; i++)
            {
                PrintCalendar(year, i);
            }
        }




        // Problem 9 : Print the number of days from the beginning of the year
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
                totalDays += NumberOfDaysInMonth(year, i);
            return totalDays + day;
        }


        // Problem 10 : Go back to a certain date from the number of days from the beginning of the year

        private struct stDate
        {
            public int day;
            public int month;
            public int year;
        }

        static private stDate GoBackToDate(int totalDays, int year)
        {
            stDate date;
            date.day = 0;
            date.month = 0;
            date.year = year;

            int numberOfDays = 0;
            for (int i = 1; i <= 12; i++)
            {

                if (totalDays - numberOfDays < NumberOfDays(year, i))
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

        static stDate GetDateFromDayOrderInYear(int DateOrderInYear, int year)
        {
            stDate date;
            int RemaningDays = DateOrderInYear;
            int MonthDays = 0;


            date.year = year;
            date.month = 1;

            while (true)
            {
                MonthDays = NumberOfDays(year, date.month);
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


        // Problem 11 : Date after adding a certain number of days to a certain date :
        static private stDate AddDaysToDate(int DaysToAdd, stDate date)
        {

            int DaysInYear = 0;
            // this is the trick to get the number of days from the beginning of the year
            int RemaningDays = DaysToAdd + DaysFromTheBeginningOfTheYear(date.year, date.month, date.day);

            while (true)
            {
                DaysInYear = NumberOfDaysInYear(date.year);
                if (RemaningDays >= DaysInYear)
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


        // Problem 12 : check if date1 is less than date2 : 
        static private bool IsDate1BeforeThanDate2(stDate date1, stDate date2)
        {
            return date1.year < date2.year ? true : (date1.year == date2.year ? date1.month < date2.month ? true : date1.month == date2.month ? (date1.day < date2.day ? true : false) : false : false);
        }


        // Problem 13 : check if date1 is equal to date2 :
        static private bool IsDate1EqualsDate2(stDate date1, stDate date2)
        {
            //return date1.year == date2.year && date1.month == date2.month && date1.day == date2.day;
            return (date1.year == date2.year ? (date1.month == date2.month ? (date1.day == date2.day ? true : false) : false) : false);
        }



        // Problem 14 : Last Day , Last Month :
        static private bool IsLastDayInMonth(stDate date)
        {
            return date.day == NumberOfDaysInMonth(date.year, date.month);
        }

        static private bool IsLastMonthInYear(stDate date)
        {
            return date.month == 12;
        }

        // Problem 15 : Increase date by one day 

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

        // Problem 16 : Difference between two dates in days
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


        // Problem 17 : Your Age in days :
        // Get the current date + using the previous method to get the age in days

        static private stDate GetCurrentDate()
        {
            // Get the current date and time
            DateTime now = DateTime.Now;

            stDate date;
            date.day = now.Day;
            date.month = now.Month;
            date.year = now.Year;

            return date;
        }


        // Problem 18 : Diff Day (Negative Days)
        static private void Swap(ref stDate date1, ref stDate date2)
        {
            stDate temp = date1;
            date1 = date2;
            date2 = temp;
        }
        static private int GetDifferenceInDays(stDate date1, stDate date2, bool IncludeEndDay = false)
        {
            int Days = 0;
            short SwapFlagValue = 1;

            if (!IsDate1BeforeThanDate2(date1, date2))
            {
                Swap(ref date1, ref date2);
                SwapFlagValue = -1;
            }

            while (IsDate1BeforeThanDate2(date1, date2))
            {
                Days++;
                date1 = IncreaseDateByOneDay(date1);
            }
            return IncludeEndDay ? Days * SwapFlagValue + 1 : Days * SwapFlagValue;

        }

        //Problem 19 : Increase date by X days

        static private stDate IncreaseDateByXDays(stDate date, int xDays)
        {
            for (int i = 1; i <= xDays; i++)
            {
                date = IncreaseDateByOneDay(date);
            }
            return date;
        }
        //Problem 20 : Increase date by one week 
        static private stDate IncreaseDateByOneWeek(stDate date)
        {
            return IncreaseDateByXDays(date, 7);
        }

        //Problem 21 : Increase date by x weeks : 
        static private stDate IncreaseDateByXWeeks(stDate date, int xWeeks)
        {
            for (int i = 1; i <= xWeeks; i++)
            {
                date = IncreaseDateByOneWeek(date);
            }
            return date;
        }

        //Problem 22 : Increase date by one month :
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
            if (date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        // Problem 23 : Increase date by x months :
        static private stDate IncreaseDateByXMonths(stDate date, int xMonths)
        {
            for (int i = 1; i <= xMonths; i++)
            {
                date = IncreaseDateByOneMonth(date);
            }
            return date;
        }

        // Problem 24 : Increase date by one year :
        static private stDate IncreaseDateByOneYear(stDate date)
        {
            date.year++;

            if(date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        // Problem 25 : Increase date by x years :
        static private stDate IncreaseDateByXYears(stDate date, int xYears)
        {
            for (int i = 1; i <= xYears; i++)
            {
                date = IncreaseDateByOneYear(date);
            }

            return date;
        }

        // Problem 26 : Increase date by x years (faster method)
        static private stDate IncreaseDateByXYearsFaster(stDate date, int xYears)
        {
            date.year += xYears;

            if (date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
                date.day = NumberOfDaysInMonth(date.year, date.month);

            return date;
        }

        // Problem 27 : Increase date by one decade (10 years) :
        static private stDate IncreaseDateByOneDecade(stDate date)
        {
            date.year += 10;
            if (date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        // Problem 28 : Increase date by x decades (10 years) :
        static private stDate IncreaseDateByXDecades(stDate date, int xDecades)
        {
            for (int i = 1; i <= xDecades; i++)
            {
                date = IncreaseDateByOneDecade(date);
            }
            return date;
        }

        // Problem 29 : Increase date by X decades (faster method)
        static private stDate IncreaseDateByXDecadesFaster(stDate date, int xDecades)
        {
            date.year += xDecades * 10;
            if (date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        // Problem 30 : Increase date by one century (100 years) :
        static private stDate IncreaseDateByOneCentury(stDate date)
        {
            date.year += 100;
            if (date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        // Problem 31 : Increase date by one Millennium (1000 years) :
        static private stDate IncreaseDateByOneMillennium(stDate date)
        {
            date.year += 1000;
            if (date.month == 2 && date.day > NumberOfDaysInMonth(date.year, date.month))
            {
                date.day = NumberOfDaysInMonth(date.year, date.month);
            }
            return date;
        }

        // Problem 31 : Decrease date by one day
        static private stDate DecreaseDateByOneDay(stDate date)
        {
            if (date.day == 1)
            {
                if (date.month == 1)
                {
                    date.year--;
                    date.month = 12;
                    date.day = 31;
                }
                else
                {
                    date.month--;
                    date.day = NumberOfDaysInMonth(date.year, date.month);
                }
            }
            else
                date.day--;

            return date;

        }

        // Problem 32 : Decrease date by X days
        static private stDate DecreaseDateByXDays(stDate date, int xDays)
        {
            for (int i = 0; i < xDays; i++)
            {
                date = DecreaseDateByOneDay(date);
            }
            return date;
        }





    }
}
