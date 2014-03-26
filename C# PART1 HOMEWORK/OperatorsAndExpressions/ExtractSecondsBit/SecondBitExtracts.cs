/*Write an expression that extracts from given integer n 
  the value of given bit at index p. Examples:
n	    binary representation	p	bit @ p
5	    00000000 00000101	    2	1
0	    00000000 00000000	    9	0
15	    00000000 00001111	    1	1
5343	00010100 11011111	    7   1
62241	11110011 00100001	    11  0
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSecondsBit
{
    class SecondBitExtracts
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
            Console.WriteLine(result);
        }
    }
}
