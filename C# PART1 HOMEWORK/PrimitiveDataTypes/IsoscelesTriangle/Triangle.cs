/*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©
  © ©
 ©   ©
© © © ©
Note that the © symbol may be displayed incorrectly at the 
console so you may need to change the console character encoding to UTF-8 and the console font.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            char copyright = '\u00A9';
            Console.WriteLine(" " + " " + " " + copyright);
            Console.WriteLine(" " + " " + copyright + " " + copyright);
            Console.WriteLine(" " + copyright + " " + " " + " " + copyright);
            Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
        }
    }
}
