/*Write a program that finds the biggest 
 of five numbers by using only five if statements.
 Examples:
a	    b	    c	    d	    e	    biggest
5	    2	    2	    4	    1	    5
-2	    -22	    1	    0	    0	    1
-2	    4	    3	    2	    0	    4
0	    -2.5	0	    5	    5	    5
-3	    -0.5	-1.1	-2	    -0.1	-0.1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreBiggestNumber
{
    class BiggestNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for a, b, c, d, e: ");
            Console.Write("a = ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double fourthNum = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double fifthNum = double.Parse(Console.ReadLine());

            if ((firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum) || (firstNum == secondNum))
            {
                Console.WriteLine("The biggest number is: {0}", firstNum);
            }
            else if ((secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum) || ( secondNum == thirdNum))
            {
                Console.WriteLine("The biggest number is: {0}", secondNum);
            }
            else if ((thirdNum > firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum) || (thirdNum == fourthNum))
            {
                Console.WriteLine("The biggest number is: {0}", thirdNum);
            }
            else if ((fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum) || (fourthNum == fifthNum))
            {
                Console.WriteLine("The biggest number is: {0}", fourthNum);
            }
            else if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > thirdNum && fifthNum > fourthNum)
            {
                Console.WriteLine("The biggest number is: {0}", fifthNum);
            }
        }
    }
}
