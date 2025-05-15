using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P4__Print_Number_In_Reversed_Order_
    {

        static public int ReadNumber()
        {
            int num;
            do
            {
                Console.WriteLine("Please enter a number ?");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num <= 0);

            return num;

        }
        static public void PrintNumberInReversedOrder(int num)
        {
            int remain = 0;
            while(num > 0)
            {
                remain = num % 10;
                num /= 10;
                Console.WriteLine(remain);
            }
        }
        static void Main(String[] arg)
        {
            PrintNumberInReversedOrder(ReadNumber());
            Console.ReadLine();

        }
    }
}
