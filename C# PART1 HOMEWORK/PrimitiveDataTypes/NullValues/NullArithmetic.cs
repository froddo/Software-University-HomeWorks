/*Create a program that assigns 
 null values to an integer and to a double variable. 
 Try to print these variables at the console. 
 Try to add some number or the null literal 
 to these variables and print the result.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class NullArithmetic
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            double? c = null;
            int? d = null;
            Console.Write(c + d);
            Console.WriteLine(a + b);
        }
    }
}
