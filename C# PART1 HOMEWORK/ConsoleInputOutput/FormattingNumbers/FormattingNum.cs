/*Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
 a floating-point b and a floating-point c and prints them in 4 virtual 
 columns on the console. Each column should have a width of 10 characters.
 The number a should be printed in hexadecimal, left aligned; then the number 
 a should be printed in binary form, padded with zeroes, then the number b 
 should be printed with 2 digits after the decimal point, right aligned; 
 the number c should be printed with 3 digits after the decimal point, left aligned. 
 Examples:
a	    b	        c	                     result
254	    11.6	    0.5	        |FE        |0011111110|     11.60|0.500     |
499	    -0.5559	    10000	    |1F3       |0111110011|     -0.56|10000     |
0	    3	        -0.1234	    |0         |0000000000|         3|-0.123    |
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNum
    {
        static void Main(string[] args)
        {
            
            int a = 254;
            int aa = 499;
            int aaa = 0;
            
            float b = 11.60f;
            float bb = -0.5559f;
            float bbb = 3f;
            
            float c = 0.5f;
            float cc = 10000;
            float ccc = -0.1234f;
            
            Console.Write("{0,-10:X}", a);
            Console.Write("|");
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("|");
            Console.Write("{0,10:F2}", b);
            Console.Write("|");
            Console.Write("{0,-10:F3}", c);
            Console.WriteLine("|");

            Console.Write("{0,-10:X}", aa);
            Console.Write("|");
            Console.Write(Convert.ToString(aa, 2).PadLeft(10, '0'));
            Console.Write("|");
            Console.Write("{0,10:F2}", bb);
            Console.Write("|");
            Console.Write("{0,-10:000}", cc);
            Console.WriteLine("|");

            Console.Write("{0,-10:X}", aaa);
            Console.Write("|");
            Console.Write(Convert.ToString(aaa, 2).PadLeft(10, '0'));
            Console.Write("|");
            Console.Write("{0,10}", bbb);
            Console.Write("|");
            Console.Write("{0,-10:F3}", ccc);
            Console.WriteLine("|");
        }
    }
}