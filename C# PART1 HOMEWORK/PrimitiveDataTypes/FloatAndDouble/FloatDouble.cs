/*Which of the following values can be assigned 
 to a variable of type float and which to a 
 variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? 
 Write a program to assign the numbers in variables and print them
 to ensure no precision is lost.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatAndDouble
{
    class FloatDouble
    {
        static void Main(string[] args)
        {
            float number = 12.345f;
            Console.WriteLine("Float number is: {0}", number);
            float secondNumber = 3456.091f;
            Console.WriteLine("Float second number is: {0}", secondNumber);
            double value = 34.567839023;
            Console.WriteLine("Double value is: {0}", value);
            double bigValue = 8923.1234857;
            Console.WriteLine("Double big value is: {0}", bigValue);

        }
    }
}
