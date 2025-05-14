using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Problem_2
    {
        // leap year : All years which are perfectly divisible by 4 are leap years except for end-of-century years. The end-of-century year must be divisible by 400 to be a leap year.
        static private bool IsLeapYear(int year)
        {
            return year % 400 == 0 ? true : (year % 4 == 0 && year % 100 != 0 ? true : false);
        }


        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsLeapYear(year) ? $"{year} is a leap year." : $"{year} is not a leap year.");
        } 

    }
}
