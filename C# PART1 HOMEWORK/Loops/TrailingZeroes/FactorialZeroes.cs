/*Write a program that calculates with 
 how many zeroes the factorial of a given 
 number n has at its end. Your program should 
 work well for very big numbers, e.g. n=100000. 
 Examples:
n	    trailing zeroes of n!	explaination
10	    2	                    3628800
20	    4	                    2432902008176640000
100000	24999	                think why
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZeroes
{
    class FactorialZeroes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for n ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger fact = 1;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            BigInteger factorial = fact;
            while (fact % 10 == 0)
            {
                counter++;
                fact /= 10;
            }
            Console.WriteLine("The zeroes of end factorial number is: {0}", counter);
            Console.WriteLine("Factorial number is: {0}", factorial);
        }
    }
}
