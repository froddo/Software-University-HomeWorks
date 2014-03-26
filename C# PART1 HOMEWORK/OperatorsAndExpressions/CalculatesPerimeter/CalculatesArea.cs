/*Write an expression that calculates rectangle’s 
perimeter and area by given width and height.
Examples:
width	height	perimeter	area
3	    4	    14	        12
2.5	    3	    11	        7.5
5	    5	    20	        25
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatesPerimeter
{
    class CalculatesArea
    {
        static void Main(string[] args)
        {
            double[] width = { 3, 2.5, 5 };
            double[] height = { 4, 3, 5 };

            CalculateRectanglePerimeterArea(width, height);
        }

        static void CalculateRectanglePerimeterArea(double[] width, double[] height)
        {
            Console.WriteLine("Area is: ");
            for (int i = 0, j = 0; i < width.Length; i++, j++)
            {
                double area = width[i] * height[j];
                Console.WriteLine(area);
            }
            Console.WriteLine("Perimeter is: ");
            for (int k = 0, m = 0; k < height.Length; k++, m++)
            {
                double perimeter = (2 * width[k]) + (2 * height[m]);
                Console.WriteLine(perimeter);
            }
        }
    }
}
