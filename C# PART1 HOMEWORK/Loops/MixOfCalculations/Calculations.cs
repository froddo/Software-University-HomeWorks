/*Write a program that reads from the console a sequence 
 of n integer numbers and returns the minimal, 
 the maximal number, the sum and the average of all numbers 
 (displayed with 2 digits after the decimal point). 
 The input starts by the number n (alone in a line) 
 followed by n lines, each holding an integer number. 
 The output is like in the examples below. 
 Examples:
 
input	output		    input	output
3       min = 1         2       min = -1
2       max = 5         -1      max = 4
5       sum = 8         4       sum = 3
1	    avg = 2,67              avg = 1.50              
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixOfCalculations
{
    class Calculations
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter integer number for n = ");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers of n ");
            int[] calculateNumbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                calculateNumbers[i] = numbers;
            }

            Console.WriteLine("The min number is {0}", FindMinNumber(calculateNumbers));
            Console.WriteLine("The max number is {0}", FindMaxNumber(calculateNumbers));
            Console.WriteLine("The sum of the numbers is {0:F2}", FindSumNumber(calculateNumbers));
            Console.WriteLine("The average number is {0:F2}", FindAverageNumber(calculateNumbers));
        }
        static int FindMinNumber(int[] calculateNumbers)
        {
            int min = calculateNumbers.Min();
            return min;
        }
        static int FindMaxNumber(int[] calculateNumbers)
        {
            int max = calculateNumbers.Max();
            return max;
        }
        static object FindSumNumber(int[] calculateNumbers)
        {
            double sum = calculateNumbers.Sum();
            return sum;
        }
        static object FindAverageNumber(int[] calculateNumbers)
        {
            double average = calculateNumbers.Average();
            return average ;
        }

           
    }
}
