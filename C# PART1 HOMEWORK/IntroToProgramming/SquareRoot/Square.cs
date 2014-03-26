/*Create a console application that
 * calculates and prints the square 
 * root of the number 12345. 
 * Find in Internet “how to 
 * calculate square root in C#”.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Square
    {
        static void Main(string[] args)
        {
            int number = 12345;
            int square = number * number;
            Console.WriteLine(square);
        }
    }
}
