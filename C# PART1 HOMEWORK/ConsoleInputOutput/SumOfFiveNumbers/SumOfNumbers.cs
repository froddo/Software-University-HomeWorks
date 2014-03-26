/*Write a program that enters 5 numbers 
 (given in a single line, separated by a space), 
 calculates and prints their sum. 
 Examples:
numbers	    sum		numbers	            sum		numbers	            sum
1 2 3 4 5	15		10 10 10 10 10	    50		1.5 3.14 8.2 -1 0	11.84
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFiveNumbers
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five integer numbers: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            int numberFour = int.Parse(Console.ReadLine());
            int numberFive = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of numbers is: {0} {1} {2} {3} {4} {5}", numberOne, numberTwo, numberThree, numberFour, numberFive, numberOne + numberTwo + numberThree + numberFour + numberFive);
        }
    }
}
