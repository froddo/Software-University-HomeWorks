/*Write a program that reads 3 integer 
  numbers from the console and prints their sum. 
 Examples:
a	    b	    c	    sum
3	    4	    11	    18
-2	    0	    3	    1
5.5	    4.5	    20.1	30.1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntegers
{
    class SumThreeIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of three numbers is: {0} + {1} + {2} = {3}", number, secNumber, thirdNumber, number + secNumber + thirdNumber);
        }
    }
}
