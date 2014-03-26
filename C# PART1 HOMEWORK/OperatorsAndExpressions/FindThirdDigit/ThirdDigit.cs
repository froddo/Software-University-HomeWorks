/*Write an expression that checks for given integer if its third digit from right-to-left is 7. 
Examples:
n	    Is Third digit 7?

5	    false
701	    true
9703	true
877	    false
777877	false
9999799	true
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int[] number = {5, 701, 9703, 877, 777877, 9999799};
            int temp = 100;
            
            for (int i = 0; i < number.Length; i++)
            {
                int result = number[i] / temp;
                result = result % 10;
                if (result == 7)
                {
                    Console.WriteLine("The number {0} has number 7 ", number[i]);
                }
                else
                {
                    Console.WriteLine("The number {0} hasn't number 7 ", number[i]);
                }
            }
        }
    }
}
