/*In combinatorics, the number of ways to choose k 
 different members out of a group of n different elements 
 (also known as the number of combinations) 
 is calculated by the following formula:
For example, there are 2598960 ways to 
withdraw 5 cards out of a standard deck 
of 52 cards. Your task is to write a program that calculates n! / (k! * (n-k)!)
 for given n and k (1 < k < n < 100). 
 Try to use only two loops. 
 Examples:
n	k	n! / (k! * (n-k)!)
3	2	3
4	2	6
10 	6	210
52	5	2598960
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MoreCalculateFactorial
{
    class MoreCalculate
    {
        static void Main()
        {
            Console.WriteLine("Enter value for n > k");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger factNAndK = 1;

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factK *= j;
            }
            for (int m = 1; m <= n - k; m++)
            {
                factNAndK *= m;
            }
            BigInteger sum = factN / (factK * factNAndK);
            Console.WriteLine(sum);

        }

       
    }
}
