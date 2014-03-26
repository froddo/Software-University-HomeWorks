/*Write a program that gets two numbers from 
 the console and prints the greater of them. 
 Try to implement this without if statements. 
 Examples:
a	    b	    greater
5	    6	    6
10	    5	    10
0	    0	    0
-5	    -2	    -2
1.5	    1.6	    1.6
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggestNumber
{
    class PrintBiggestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer numbers: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int[] number = {numberOne, numberTwo};
            int getMax = number.Max();
            Console.WriteLine("The biggest number is: {0}", getMax);
        }
    }
}
