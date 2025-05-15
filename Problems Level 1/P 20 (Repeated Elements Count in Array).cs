using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem_Solving_1
{
    internal class P_20__Repeated_Elements_Count_in_Array_
    {
        static private int[] arr;
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

        static public void FillArrayWithElements(ref int[] arr, int length)
        {
            arr = new int[length];
            for(int i=0;i<length;i++)
            {
                Console.Write($"Element[{i+1}] : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static public void PrintArrayElements(int[] arr, int length)
        {
            Console.WriteLine("\n\nOriginal Array :");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static public int CountRepeatedElementInArray(int[] arr, int length,int NumToCount)
        {
           /* 
            int Count = 0;
            foreach(int i in arr)
                if (i == NumToCount) Count++;

            return Count;*/

            // other method with "Linq" namespace : 
            // Count occurences of target number in array : 
            return arr.Count(n => n == NumToCount);
            
            /*
                numbers.Count(n => n == target);:
                The.Count() method takes a predicate(a condition) as an argument.
                For each element n in arr, it checks if n is equal to target.
                It returns the total count of elements that match the condition.
            */
        }

        public static void Main(string[] args)
        {
            
            int length = ReadPositiveNumber("Please enter the number of elements in array ?");

            // "ref" :  When you use ref with an array,
            // changes to the array elements and, if desired,
            // the array reference (such as resizing or reassigning) will persist outside the function.

            // (Important!!) ref in Method Call: You must use ref in both the method signature and the method call.
           
            FillArrayWithElements(ref arr, length);
            int numToCount = ReadPositiveNumber("\n\nEnter the number you want to check : ");
            
            PrintArrayElements(arr, length);
            Console.WriteLine($"{numToCount} is repeated {CountRepeatedElementInArray(arr,length,numToCount)} time(s).");
            Console.ReadLine();
        }


    }
}
