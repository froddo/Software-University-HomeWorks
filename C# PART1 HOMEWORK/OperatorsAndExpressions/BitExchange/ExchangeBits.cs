/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 
 of given 32-bit unsigned integer. 
 Examples:
n	            binary representation of n	            binary result	                        result
1140867093	    01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
255406592	    00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	    137966136
4294901775	    11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
5351	        00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111     67114183
2369124121	    10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	    2335569705
*/

using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number ");
            long number = long.Parse(Console.ReadLine());

            long mask = 1 << 3;
            long thirdBit = (number & mask) << 21;
           
            mask = 1 << 24;
            long twentyFourBit = (number & mask) >> 21;
           

            if (thirdBit == 1)
            {
                mask = 1 << 24;
                number = number | mask;
            }
            else if (thirdBit == 0)
            {
                mask = ~(1 << 24);
                number = number & mask;
            }
            if (twentyFourBit == 1)
            {
                mask = 1 << 3;
                number = number | mask;
            }
            else if (twentyFourBit == 0)
            {
                mask = ~(1 << 3);
                number = number & mask;
            }
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            mask = 1 << 4;
            long fourthBit = (number & mask) >> 4;

            mask = 1 << 25;
            long twentyFiveBit = (number & mask) >> 25;

            if (fourthBit == 1)
            {
                mask = 1 << 25;
                number = number | mask;
            }
            else if (fourthBit == 0)
            {
                mask = ~(1 << 25);
                number = number & mask;
            }
            if (twentyFiveBit == 1)
            {
                mask = 1 << 4;
                number = number | mask;
            }
            else if (twentyFiveBit == 0)
            {
                mask = ~(1 << 4);
                number = number & mask;
            }
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            mask = 1 << 5;
            long fiveBit = (number & mask) >> 5;

            mask = 1 << 26;
            long twentySixBit = (number & mask) >> 26;

            if (fiveBit == 1)
            {
                mask = 1 << 26;
                number = number | mask;
            }
            else if (fiveBit == 0)
            {
                mask = ~(1 << 26);
                number = number & mask;
            }
            if (twentySixBit == 1)
            {
                mask = 1 << 5;
                number = number | mask;
            }
            else if (twentySixBit == 0)
            {
                mask = ~(1 << 5);
                number = number & mask;
            }
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
