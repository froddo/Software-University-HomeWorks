/*Write an if-statement that takes two integer 
 variables a and b and exchanges their values 
 if the first one is greater than the second one. 
 As a result print the values a and b, separated by a space. 
 Examples:
a	    b	    result
5	    2	    2 5
3	    4	    3 4
5.5	    4.5	    4.5 5.5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class ExchangeGrater
    {
        static void Main()
        {
            Console.WriteLine("Please enter number for a and b: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            if (a > b)
            {
                c = a;
                a = b;
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", c);
            }
            else if(b > a)
            {
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
            }
            
        }
    }
}
