/*Write a program that exchanges bits {p, p+1, …, p+k-1} 
 with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
 The first and the second sequence of bits may not overlap. 
 Examples:
n	        p	q	k	binary representation of n	    binary result	    result
1140867093	3	24	3	01000100 00000000               01000010 00000000   1107312677
        	24	3	3   01000000 00010101	            01000000 00100101

4294901775	2	22	10	11111111 11111111               11111001 11111111   4194238527
            2	8	11  00000000 00001111	            00000000 00111111

2369124121  26	0	7   10001101 00110101               01110001 10110101   1907751121
            -1	0	33  11110111 00011001	            11111000 11010001	
987654321		          -                              	-	            overlapping
123456789		          -                              	-	            out of range
33333333333 	          -                              	-	            out of range
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeAdvance
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("p = ");
            byte p = byte.Parse(Console.ReadLine());
            Console.Write("q = ");
            byte q = byte.Parse(Console.ReadLine());
            Console.Write("k = ");
            byte k = byte.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
               uint mask = n & (uint)(1 << p);
               uint bitP = (uint)mask >> p;
               mask = n & (uint)(1 << q);
               uint bitQ = mask >> q;

               if (bitP == 1)
               {
                  mask = (uint)(1 << q);
                  n = n | mask;
               }
               else if(bitP == 0)
               {
                   mask = (uint)(~(1 << q));
                   n = n & mask;
               }
               if (bitQ == 1)
               {
                  mask = (uint)(1 << p);
                  n = n | mask;
               }
               else if (bitQ == 0)
               {
                   mask = (uint)(~(1 << p));
                   n = n & mask;
               }
               p++;
               q++;
            }
            Console.WriteLine(n);
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        } 
    }
}
