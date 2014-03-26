/*Write a program that calculates n! / k! 
 for given n and k (1 < k < n < 100). 
 Use only one loop. 
 Examples:
n	k	n! / k!
5	2	60
6	5	6
8	3	6720
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFactorial
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for n and k");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int fact = 1;
            for (int i = n; i > k; i--)
            {
                fact *= i; 
            }
            Console.WriteLine(fact);
        }
    }
}
