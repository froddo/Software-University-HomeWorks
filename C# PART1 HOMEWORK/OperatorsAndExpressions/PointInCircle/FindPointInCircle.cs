/* Write an expression that checks if given point (x,  y) 
is inside a circle K({0, 0}, 2). 
Examples:
x	    y	        inside	 
0	    1	        true	
-2	    0	        true	
-1	    2	        false	
1.5	    -1	        true	
-1.5	-1.5	    false	
100	    -30	        false	
0	     0	        true	
0.2	    -0.8	    true	
0.9	    -1.93	    false	
1	    1.655	    true	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInCircle
{
    class FindPointInCircle
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            if (Math.Sqrt(x * x + y * y) <= 2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
