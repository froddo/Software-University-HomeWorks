/*Write a program that reads two positive 
 integer numbers and prints how many numbers
 p exist between them such that the reminder 
 of the division by 5 is 0. 
 Examples:
start	    end	    p	    comments
17	        25	    2	    20, 25
5	        30	    6	    5, 10, 15, 20, 25, 30
3	        33	    6	    5, 10, 15, 20, 25, 30
3	        4	    0	    -
99	        120	    5	    100, 105, 110, 115, 120
107	        196	    18	    110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNumbersByGivenNumber
{
    class SetNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for start and end");
            Console.Write("Start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End = ");
            
            int end = int.Parse(Console.ReadLine());
            int counter = 0;
            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (start % 10 == 0 || start % 10 == 5)
                {
                    counter++;
                    numbers.Add(i);
                }
                start++;
            }
            Console.WriteLine("The numbers in range from start to end is: {0}", counter);
            foreach (var item in numbers)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
           
        }
    }
}
