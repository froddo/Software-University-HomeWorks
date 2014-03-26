/*Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. Examples:
n	matrix		n	matrix		n	matrix
2	1 2         3	1 2 3       4	1 2 3 4
    2 3		        2 3 4           2 3 4 5
                    3 4 5           3 4 5 6
                		            4 5 6 7                              
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class MatrixNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number 1 < n <= 20");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("{0,3}", row + col -1);
                }
                Console.WriteLine();
            }
        }
    }
}
