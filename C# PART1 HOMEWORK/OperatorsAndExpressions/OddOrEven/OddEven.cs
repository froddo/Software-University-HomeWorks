/*Write an expression that checks if given integer is odd or even. 
Examples:
n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddEven
    {
        static void Main()
        {
            int[] oddOrEven = { 2, 3, -4, -1 }; 

            FindOddOrEven(oddOrEven); 

        }
        static void FindOddOrEven(int[] oddOrEven)
        {
            foreach (var item in oddOrEven)
            {
                if ((item & 1) == 1)
                {
                    Console.WriteLine("The Number {0} is odd", item);
                }
                else
                {
                    Console.WriteLine("The Number {0} is even ", item);
                }
            }
        }
    }
}
