/*Write a program that enters from the console
 a positive integer n and prints all the numbers 
 from 1 to n, on a single line, separated by a space.
 Examples:
n	output
3	1 2 3
5	1 2 3 4 5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNNumbrers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer numbers for n: ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
