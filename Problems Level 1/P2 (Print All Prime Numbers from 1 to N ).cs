using System;
using System.Linq;

namespace Problem_Solving_1
{
    internal class P2__Print_All_Prime_Numbers_from_1_to_N__
    {
        

        static public bool isPrimeNumber(int num)
        {
                // Return false for numbers less than 2
                if (num<= 1)
                    return false;

                // Check for factors from 2 up to the square root of the number
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false; // Not a prime number
                }

                return true; // Prime number
        }
        // Other method of Kunal DSA : 
        static public bool PrimeNumber(int num)
        {
            if (num <= 1)
                return false;
            int c = 2;
            while(c *c <= num) // c*c <= num  == Math.sqrt(num) >= c (square root of a number ) 
            {
                if (num % c == 0)
                    return false; 
                c++;
            }
            return true;
        }


        static public void Main(string[] args) {

            Console.WriteLine("Please enter a number ? ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(PrimeNumber(i) ? i + " is prime number." : i + " is not prime number.");
            }

            Console.ReadLine();
        }
    }
}
