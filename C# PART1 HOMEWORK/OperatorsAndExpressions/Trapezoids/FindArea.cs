/*Write an expression that calculates trapezoid's area by given sides a and b and height h.
 Examples:
a	    b	    h	    area	 
5	    7	    12	    72	
2	    1	    33	    49.5	
8.5	    4.3	    2.7	    17.28	
100	    200	    300	    45000	
0.222	0.333	0.555	0.1540125	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class FindArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter trapecoid's area for sides-a, sides-b, height-h");
            
            Console.Write("Enter for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter for h: ");
            double h = double.Parse(Console.ReadLine());
            
            Console.Write("The area is: ");
            Console.WriteLine(((a + b) * h) / 2);  // formula --> area = ((a + b) * h) / 2
        }
    }
}
