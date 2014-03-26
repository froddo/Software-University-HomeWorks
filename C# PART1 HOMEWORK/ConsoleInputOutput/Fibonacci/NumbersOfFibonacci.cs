/*Write a program that reads a number n and prints 
 on the console the first n members of the Fibonacci 
 sequence (at a single line, separated by spaces)
 : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
 Note that you may need to learn how to use loops. 
 Examples:
n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class NumbersOfFibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of n = ");
            int n = int.Parse(Console.ReadLine());

            BigInteger fibOne = 0;
            BigInteger fibTwo = 1;
            BigInteger sum = 0;
            Console.WriteLine(sum);
            int i = 0;
            
            for (i = 1; i < n; i++)
            {
                sum = sum + fibTwo;
                fibTwo = fibOne;
                fibOne = sum;
                Console.WriteLine(sum);
            }
            Console.WriteLine("All numbers are {0}", i);
        }
    }
}
