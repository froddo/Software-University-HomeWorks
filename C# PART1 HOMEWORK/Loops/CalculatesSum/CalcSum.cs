/*Write a program that, 
 for a given two integer numbers n and x, 
 calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
 Use only one loop. 
 Print the result with 5 digits after the decimal point.
n	x	S
3	2	2.00000
4	3	2.04151
5	-4	0.75781
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatesSum
{
    class CalcSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value for n and x");
            Console.Write("n = ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double fact = 1;
            double sum = 1;
            double sumX = 1;
            
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sumX *= x;
                sum = sum + fact / sumX;
                
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
