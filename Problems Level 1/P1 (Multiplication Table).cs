using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_1
{
    internal class P1__Multiplication_Table_
    {

        static public void Header()
        {
            Console.Write("\t\t\t\tMultiplication Table From 1 to 10\n\n");
            for (int i = 1; i <= 10; i++)
                Console.Write("\t" + i);
            Console.WriteLine("\n------------------------------------------------------------------------------------");
        }
        static public void MultiplicationTable()
        {
            for(int i =  1; i <= 10; i++)
            {
                // Column Seperator (if i < 10 n7otoha 3adia else na9so espace bech tji bedhabet ) :  
                Console.Write((i < 10 ? " " + i + "   |  " : " " + i + "  |  ")); 
                
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.Write("\n");
            }
        }
        static public void Main(string[] args)
        {

            Header();
            MultiplicationTable(); 
            Console.ReadLine();

        }

    }
}
