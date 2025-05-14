using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class Program
    {
        static string NumberToText(UInt64 num)
        {

            string[] arr1 = { "", " One", " Two", " Three", " Four", " Five", " Six", " Seven", " Eight", " Nine", " Ten", " Eleven", " Twelve", " Thirteen", " Fourteen", " Fifteen", " Sixteen", " Seventeen", " Eighteen", " Nineteen" };
            string[] arr2 = { "", "", " Twenty", " Thirty", " Fourty", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };


            if (num == 0) return arr1[0];

            if (num >= 1 && num <= 19)
                return arr1[num]  + NumberToText(num / 10);

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


        static void Main(string[] args)
        {


            UInt64 num;
            Console.Write("Enter a number ?");
            num = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine(NumberToText(num));


        }
    }
}
