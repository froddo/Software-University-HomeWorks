﻿/*Write an expression that checks for given point 
(x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2). 
Examples:
x	    y	    inside K & outside of R	 
1	    2	    yes	
2.5	    2	    no	
0	    1	    no	
2.5	    1	    no	
2	    0	    no	
4	    0	    no	
2.5	    1.5	    yes	
1	    2.5	    yes	
-100	-100	no	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoints
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y = ");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
            bool inRectangle = ((-1 <= x) && (x <= 5) && (-1 <= y) && (y <= 1));
            Console.Write("The point in " + " ");
            Console.WriteLine(inCircle? "whitin the circle and " + " " : "outside of the circle and ");
            Console.WriteLine(inRectangle? "within the rectangle " : "outside of the rectangle");
        }
    }
}
