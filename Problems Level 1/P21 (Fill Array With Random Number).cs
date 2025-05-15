using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P21__Fill_Array_With_Random_Number_
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
        static public int RandomNumber(int from , int to )
        {
            return rand.Next(from , to +1); 
        }

        static public void FillArrayWithRandomNumber(ref int[] arr, ref int length)
        {
            length = ReadPositiveNumber("Please enter the number of elements in array ?");
            arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = RandomNumber(1, 100);
            }
        }

        static public void PrintArrayElements(int[] arr)
        {
            Console.WriteLine("\n\nArray Elements :");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            FillArrayWithRandomNumber(ref arr, ref length);
            PrintArrayElements(arr);
            Console.ReadLine();
        }
    }
}
