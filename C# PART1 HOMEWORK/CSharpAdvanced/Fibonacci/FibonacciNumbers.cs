/*Define a method Fib(n) that calculates the nth Fibonacci number.
 Examples:
n	Fib(n)
0	    0
1       1
2	    1
3	    2
4	    3
5	    5
6	    8
11	    89
12      144
25	    75025
26	    121393
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number n ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        static void Fib(int n)
        {
            BigInteger fibOne = 0;
            BigInteger fibTwo = 1;
            BigInteger sum = 0;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(sum);
                sum = fibOne + fibTwo;
                fibTwo = fibOne;
                fibOne = sum;
            }
        }
    }
}
