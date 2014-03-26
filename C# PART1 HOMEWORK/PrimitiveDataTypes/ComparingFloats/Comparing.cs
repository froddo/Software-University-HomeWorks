/*Write a program that safely compares floating-point numbers
 with precision eps = 0.000001. Note that we cannot directly 
 compare two floating-point numbers a and b by a==b 
 because of the nature of the floating-point arithmetic.
 Therefore, we assume two numbers are equal if they are 
 more closely to each other than a fixed constant eps. 
 Examples:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Comparing
    {
        static void Main()
        {
            decimal number = 3.4444444444444444446m;
            float value = 2.456f;
            
            Console.WriteLine("The float number is {0}", value, CompareFloat(number, value));
        }
        static float CompareFloat(decimal number, float value)
        {
            if (Math.Abs((float)number - value) < 0.000001) 
            {
                return (float)number;
            }
            else if (value < 0.000001)
            {
                return value;
            }
            else if ((float)number == value)
            {
                return value;
            }
            else
            {
                return value;
            }
        }
            
    }
}
