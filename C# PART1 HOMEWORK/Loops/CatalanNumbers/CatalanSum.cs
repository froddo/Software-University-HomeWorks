/*In combinatorics, the Catalan 
 numbers are calculated by the following formula: 
Write a program to calculate the nth Catalan 
 number by given n (1 < n < 100). 
 Examples:
n	Catalan(n)
0	1
5	42
10	16796
15	9694845
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class CatalanSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number for n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factOne = 1;
            BigInteger factTwo = 1;
            BigInteger factThree = 1;
            BigInteger catalanSum = 0;
            for (int i = 1; i <= n; i++)
            {
                factOne = factOne * i;
            }
            for (int j = 1; j <= n * 2; j++)
            {
                factTwo = factTwo * j;
            }
            for (int m = 1; m <= n + 1; m++)
            {
                factThree = factThree * m;
            }
            catalanSum = factTwo / (factOne * factThree);
            Console.WriteLine(catalanSum);
        }
    }
}
