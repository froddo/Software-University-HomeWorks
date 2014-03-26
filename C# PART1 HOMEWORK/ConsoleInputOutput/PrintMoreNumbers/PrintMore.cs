/*Write a program that enters a number n 
 and after that enters more n numbers and 
 calculates and prints their sum. 
 Note that you may need to use a for-loop. 
 Examples:
numbers	sum		numbers	sum		numbers	sum
3       90      5       6.5	    1		1
20	            2               1
60              -1
10              -0.5
                 4
                2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMoreNumbers
{
    class PrintMore
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of numbers: ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double [n];

            for (int i = 0; i < n; i++)
            {
                double moreNumber = double.Parse(Console.ReadLine());
                numbers[i] = moreNumber;
            }
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}
