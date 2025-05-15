using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems
{
    internal class Problem_6
    {
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

        static void Main(string[] args)
        {
            Console.Write("Please enter the year ? ");
            int year = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter the month ? ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Please enter the day ? ");
            int day = Convert.ToInt32(Console.ReadLine());

            int DayOrder = GetDayOrder(year, month, day);

            Console.WriteLine("\n***********************");
            Console.WriteLine($"Date      : {day}/{month}/{year}");
            Console.WriteLine($"Day Order : {DayOrder}");
            Console.WriteLine($"Day Name  : {GetDayName(DayOrder)}");
            Console.WriteLine("***********************");





        }

    }
}
