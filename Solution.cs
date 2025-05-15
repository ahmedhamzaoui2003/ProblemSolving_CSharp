using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    // in this file we will put the important methods of each problem :
    internal class Solution
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
        static private int NumberOfDays(int year)
        {
            return IsLeapYear(year) ? 366 : 365;
        }
        static private int NumberOfHours(int year)
        {
            return NumberOfDays(year) * 24;
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
            List<int> daysInMonth = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return IsLeapYear(year) && (month == 2) ? 29 : daysInMonth[month - 1];
            //return month == 2 ? (IsLeapYear(year) ? 29 : 28) : daysInMonth[month-1];
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

    }
}
