using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P24__Average_of_Random_Array_
    {
        static private int[] arr;
        static private int length;

        static private Random rand = new Random();

        static public int ReadPositiveNumber(string message)
        {
            int num;
            do
            {
                Console.WriteLine(message);
                num = Convert.ToInt32(Console.ReadLine());

            } while (num <= 0);

            return num;
        }
        static public int RandomNumber(int from, int to)
        {
            return rand.Next(from, to + 1);
        }

        static public void FillArrayWithRandomNumber()
        {

            length = ReadPositiveNumber("Please enter the number of elements in array ?");

            arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = RandomNumber(1, 100);
            }

        }

        static public void PrintArrayElements()
        {
            Console.WriteLine("\nArray Elements :");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static public float AverageOfRandomArray()
        {
            // one line of code : using System.linq :
            return (float)arr.Average();

            // other method : (classic ) 

            /*    int sum = 0;
                foreach (int i in arr)
                {
                    sum += i;
                }
                return (float)sum/length;*/
        }

        public static void Main(string[] args)
        {
            FillArrayWithRandomNumber();
            PrintArrayElements();
            Console.WriteLine("Average of all numbers is : " + AverageOfRandomArray());
            Console.ReadLine();
        }
    }
}
