/*Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:
n	    binary representation of n	p	bit @ p == 1
5	    00000000 00000101	        2	true
0	    00000000 00000000	        9	false
15	    00000000 00001111	        1	true
5343	00010100 11011111	        7	true
62241	11110011 00100001	        11	false
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitsAtPosition
{
    class CheckBitsPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number for n and p");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());

            int bit = 1;
            int mask = p;
            int res = n >> mask;
            int result = res & bit;
            

            if (result == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
