using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_7
    {
        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        static private int NumberOfDaysInMonth(int year, int month)
        {
            List<int> daysInMonth = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return IsLeapYear(year) && (month == 2) ? 29 : daysInMonth[month - 1];
            //return month == 2 ? (IsLeapYear(year) ? 29 : 28) : daysInMonth[month-1];
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

        static private string GetMonthDay(int month)
        {
            string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            return Months[month - 1];
        }

        static private void PrintCalendar(int year , int month)
        {
            Console.WriteLine($"\n  __________________{GetMonthDay(month)}___________________\n");
            Console.WriteLine("  Sun   Mon   Tue   Wed   Thu   Fri   Sat\n"); 

            int daysInMonth = NumberOfDaysInMonth(year, month);
            int dayOrder = GetDayOrder(year, month, 1);
            int counter = dayOrder;

            int i;
            for(i =0; i < dayOrder; i++)
            {
                Console.Write("      ");
            }
            for(int j = 1; j <= daysInMonth; j++)
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

        static void Main(string[] args)
        {
            Console.Write("Please enter a year ?");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a month ?");
            int month = Convert.ToInt32(Console.ReadLine());

            PrintCalendar(year, month);
        }

    }
}
