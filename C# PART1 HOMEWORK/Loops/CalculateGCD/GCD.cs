/*Write a program that calculates 
 the greatest common divisor 
 (GCD) of given two integers a and b. 
 Use the Euclidean algorithm (find it in Internet). 
 Examples:
a	    b	    GCD(a, b)
3	    2	    1
60	    40	    20
5	    -15	    5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers for a and b");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The GCD result is: {0}", CalculateGCD(a, b));
        }

        static int CalculateGCD(int a, int b)
        {
            if (a >= 0 && b >= 0)
            {
                while (a != b)
                {
                    if (a == 0)
                    {
                        return b;
                    }
                    else if (b == 0)
                    {
                        return a;
                    }
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
            }
            return a;
        }
    }
}
