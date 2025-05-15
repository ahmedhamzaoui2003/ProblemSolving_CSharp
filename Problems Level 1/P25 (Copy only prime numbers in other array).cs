using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P25__Copy_only_prime_numbers_in_other_array_
    {
        static private int[] arr;
        static private int[] CopyArray;

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
        static public int[] FillArrayWithRandomNumber()
        {

            int length = ReadPositiveNumber("Please enter the number of elements in array ?");

            int[]Array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Array[i] = RandomNumber(1, 100);
            }
            return Array;
        }

        static public bool isPrimeNumber(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        static public void PrintArrayElements(Array array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static public int[] CopyOnlyPrimeNumbers(int[] arrSource , int[] copyArray)
        {
            
            int len = 0;
            for (int i = 0; i < arrSource.Length; i++)
            {
                if (isPrimeNumber(arr[i])){
                    copyArray[len] = arrSource[i];
                    ++len;
                }
            }
            return copyArray;
        }

        public static void Main(string[] args)
        {

            arr = FillArrayWithRandomNumber();

            Console.WriteLine("\nArray 1 Elements :");
            PrintArrayElements(arr);

            CopyArray = CopyOnlyPrimeNumbers(arr,CopyArray);

            Console.WriteLine("\nArray 2 Elements :");
            PrintArrayElements(CopyArray);

            Console.ReadLine();

        }
    }
}
