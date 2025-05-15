using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P17__Random_Number_From_1_to_10_
    {
        static public void Print3RandomNumberFrom1To10()
        {
            Random RandomNumber = new Random();
            for (int i = 0; i < 3; i++)
                Console.WriteLine(RandomNumber.Next(1,10));
        }
        static public void Main(string[] args)
        {
            Print3RandomNumberFrom1To10();
            Console.ReadLine();
        }
    }
}
