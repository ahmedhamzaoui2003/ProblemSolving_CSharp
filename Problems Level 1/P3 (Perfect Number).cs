using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P3__Perfect_Number_
    {
        static public bool isPerfectNumber(int num)
        {
            int sumOfDivisors = 1 ;
            for(int i = 2; i<= num /2; i++)
            {
                if (num % i == 0)
                    sumOfDivisors += i;
            }
            return sumOfDivisors == num;
        }

        static void Main(String[] arg )
        {

            Console.WriteLine("Please enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isPerfectNumber(num) ? num + " is Perfect" : num + " is not Perfect");
            Console.ReadLine();
        }
    }
}
