using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.Problems_Level_2
{
    internal class Problem_63_and_64
    {
        private struct stDate
        {
            public int day;
            public int month;
            public int year;
        }

        static private stDate StringToDate(string sDate)
        {

            stDate date;
            
            string[] dates = sDate.Split('/');

            date.day = Convert.ToInt32(dates[0]); 
            date.month= Convert.ToInt32(dates[1]); 
            date.year = Convert.ToInt32(dates[2]);

            return date;
        }

        static private string DateToString(stDate date)
        {
            return date.day + "/" + date.month + "/" + date.year;
        }

        static void Main(string[] args)
        {
            stDate date;

            string sDate = "31/3/2022";

            date = StringToDate(sDate);
            Console.WriteLine("\nDay: " + date.day);
            Console.WriteLine("Month: " + date.month);
            Console.WriteLine("Year: " + date.year);

            Console.WriteLine("\nYou Entered : " + DateToString(date));
            
            
        }
    }
}
