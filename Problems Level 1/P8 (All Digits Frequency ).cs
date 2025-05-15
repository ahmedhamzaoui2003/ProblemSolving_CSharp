using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P8__All_Digits_Frequency__
    {
        static public int ReadNumber(string message)
        {
            int num;
            do
            {
                Console.WriteLine(message);
                num = Convert.ToInt32(Console.ReadLine());

            } while (num <= 0);

            return num;
        }

        static public int DigitFrequency(int num, int digitToCount)
        {
            int Frequency = 0, Remainder = 0;
            while (num > 0)
            {
                Remainder = num % 10;
                num /= 10;
                if (Remainder == digitToCount)
                    Frequency++;
            }
            return Frequency;

        }

        /*
            Note : If you are converting a numeric character (e.g., '0' to '9') and want its integer value,
            you can use Char.GetNumericValue to convert the character to a double first, and then cast it to int if necessary.
         */
        static public void PrintAllDigitsFrequency(int num)
        {
            string strNumber = num.ToString();
            HashSet<int> numbers = new HashSet<int>();
            List<int> frequencies = new List<int>();
            
       
            foreach(char c in strNumber)
                numbers.Add((int)char.GetNumericValue(c));

            foreach (int i in numbers)
            {
                frequencies.Add(DigitFrequency(Convert.ToInt32(strNumber), i));
            }

            List<int> results = new List<int>(numbers);
            int index = 0;
            
            foreach (int i in frequencies)
                Console.WriteLine($"Digit {results[index++]} Frequency is {i} Time(s).");
        }

        // Other simple method :
        static public void PrintAllDigitsFrequency2(int num)
        {
            for (int i = 0; i<= 9; i++)
            {
                int Frequency = 0;
                Frequency = DigitFrequency(num, i);
                if (Frequency > 0)
                   Console.WriteLine($"Digit {i} Frequency is {Frequency} Time(s).");
            }
        }
        static void Main(string[] args)
        {
            int num = ReadNumber("Please enter a number ? ");
            PrintAllDigitsFrequency2(num);
            Console.ReadLine();
            
        }   
    }
}
