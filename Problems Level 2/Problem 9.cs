using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_9
    {
        static private bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
        
        static private int NumberOfDays(int year , int month)
        {

            int[] arrDaysInMonth = { 31, IsLeapYear(year) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return arrDaysInMonth[month - 1];

        }
        static private int DaysFromTheBeginningOfTheYear(int year,int month, int day)
        {
            int TotalDays = 0;
            for(int i =1; i< month; i++)
            {
                TotalDays += NumberOfDays(year,i);
            }
            return TotalDays + day;

        }
        static void Main(string[] args)
        {
            int day, month, year;
            
            Console.WriteLine("please enter the day ?");
            day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the month ?");
            month= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the year ?");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nNumber of Days from the beginning of the year is {DaysFromTheBeginningOfTheYear(year, month, day)}");

        }

    }
}
