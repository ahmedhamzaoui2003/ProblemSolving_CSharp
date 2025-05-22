using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_13
    {
        private struct stDate
        {
            public int day;
            public int month;
            public int year;
        }

        static private bool IsDate1EqualsDate2(stDate date1, stDate date2)
        {
            //return date1.year == date2.year && date1.month == date2.month && date1.day == date2.day;
            return (date1.year == date2.year ? (date1.month == date2.month ? (date1.day == date2.day ? true : false) : false ): false);
        }

        static void Main(string[] args)
        {
            stDate date1, date2;
            date1.day = 12;
            date1.month = 3;
            date1.year = 2022;


            date2.day = 12;
            date2.month = 3;
            date2.year = 2022;

            Console.WriteLine(IsDate1EqualsDate2(date1, date2) ? "Yes, Date1 is Equal to Date2" : "No, Date1 is not Equal to Date2");
        }


    }
}
