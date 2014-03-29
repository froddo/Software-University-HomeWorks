/*Write a program that reads a number n and a sequence of n integers, 
 sorts them and prints them. Examples:
Input	Output
5       -3
3        0
-3      2
2       3
122     122
0	
      
3       0
0       0
1       1
0	 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number to create sequence of n numbers: ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sequence of n numbers: ");
            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(number);
            Console.WriteLine("Output: ");
            foreach (var item in number)
            {
                Console.WriteLine("   " + item);
            }
        }
    }
}
