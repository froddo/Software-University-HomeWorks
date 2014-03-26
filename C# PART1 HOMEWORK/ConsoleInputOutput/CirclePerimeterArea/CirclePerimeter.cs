/*Write a program that reads the radius r of a circle
 and prints its perimeter and area formatted with
 2 digits after the decimal point. 
 Examples:
r	    perimeter	area
2	    12.57	    12.57
3.5	    21.99	    38.48
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterArea
{
    class CirclePerimeter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius off the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = 2 * pi * radius;
            double perimeter = pi * radius * radius;
            Console.WriteLine("{0:F2}", area);
            Console.WriteLine("{0:F2}", perimeter);
        }
    }
}
