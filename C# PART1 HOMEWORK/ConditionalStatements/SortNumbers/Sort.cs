/*Write a program that enters 3 real numbers
 and prints them sorted in descending order. 
 Use nested if statements. 
 Don’t use arrays and the built-in sorting functionality. 
 Examples:
a	    b	    c	    result
5	    1	    2	    5 2 1
-2	    -2	    1	    1 -2 -2
-2	    4	    3	    4 3 -2
0	    -2.5	5	    5 0 -2.5
-1.1	-0.5	-0.1	-0.1 -0.5 -1.1
10	    20	    30	    30 20 10
1	    1	    1	    1 1 1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Sort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers fot given a, b, c");
            Console.Write("a = ");
            double numberOne = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double numberTwo = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double numberThree = double.Parse(Console.ReadLine());
            
            double max = 0;
            double middle = 0;
            double small = 0;

            if (numberOne > numberTwo && numberTwo > numberThree)
            {
               max = numberOne;
            }
            else if (numberTwo > numberOne && numberOne > numberThree)
            {
                max = numberTwo;
            }
            else if (numberThree > numberOne && numberOne > numberTwo)
            {
                max = numberThree;
            }
            else if (numberThree > numberOne && numberThree > numberTwo)
            {
                max = numberThree;
            }
            else if (numberOne < numberTwo && numberThree < numberTwo)
            {
                max = numberTwo;
            }
            else if (numberOne > numberTwo && numberOne > numberTwo)
            {
                max = numberOne;
            }

            if (numberOne < numberTwo && numberTwo < numberThree)
            {
                small = numberOne;
            }
            else if (numberTwo < numberOne && numberOne < numberThree)
            {
                small = numberTwo;
            }
            else if (numberThree < numberOne && numberOne < numberTwo)
            {
                small = numberThree;
            }
            else if (numberThree < numberOne && numberOne < numberTwo)
            {
                small = numberTwo;
            }
            else if (numberOne < numberTwo && numberOne < numberTwo)
            {
                small = numberOne;
            }
            else if(numberOne > numberTwo && numberTwo < numberThree)
            {
                small = numberTwo;
            }
            else if (numberOne > numberTwo && numberTwo > numberThree)
            {
                small = numberThree;
            }

            if (numberOne < numberTwo && numberTwo < numberThree)
            {
                middle = numberTwo;
            }
            else if (numberTwo < numberOne && numberOne < numberThree)
            {
                middle = numberOne;
            }
            else if (numberOne < numberThree && numberThree < numberTwo)
            {
                middle = numberThree;
            }
            else if (numberThree < numberTwo && numberTwo < numberOne)
            {
                middle = numberTwo;
            }
            else if (numberOne > numberTwo && numberThree > numberTwo )
            {
                middle = numberThree;
            }
            else if (numberOne < numberTwo && numberThree < numberTwo)
            {
                middle = numberOne;
            }

            if ( numberTwo == numberThree && numberOne > numberTwo)
            {
                max = numberOne;
                middle = numberTwo;
                small = numberThree;
            }
            else if (numberTwo == numberThree && numberOne < numberTwo)
            {
                max = numberTwo;
                middle = numberThree;
                small = numberOne;
            }
            else if (numberOne == numberThree && numberOne > numberTwo)
            {
                max = numberOne;
                middle = numberThree;
                small = numberTwo;
            }
            else if (numberOne == numberThree && numberOne < numberTwo)
            {
                max = numberTwo;
                middle = numberOne;
                small = numberThree;
            }
            else if (numberOne == numberTwo && numberOne > numberThree)
            {
                max = numberOne;
                middle = numberTwo;
                small = numberThree;
            }
            else if (numberOne == numberTwo && numberOne < numberThree)
            {
                max = numberThree;
                middle = numberTwo;
                small = numberOne;
            }
            else if (numberOne == numberTwo && numberTwo == numberThree)
            {
                max = numberOne;
                middle = numberTwo;
                small = numberThree;
            }

            Console.Write("{0} {1} {2}", max, middle, small);
            Console.WriteLine();
        }
    }
}
