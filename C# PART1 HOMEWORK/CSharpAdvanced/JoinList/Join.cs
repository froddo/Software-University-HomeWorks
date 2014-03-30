/*Write a program that takes as input two lists of integers and joins them. 
 The result should hold all numbers from the first list, and all numbers
 from the second list, without repeating numbers, and arranged in increasing order. 
 The input and output lists are given as integers, separated by a space, each list at a separate line. 
 Examples:
Input	                Output
20 40 10 10 30 80
25 20 40 30 10	        10 20 25 30 40 80
5 4 3 2 1
6 3 2	                1 2 3 4 5 6
1
1	                    1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinList
{
    class Join
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {20, 40, 10, 10, 30, 80};

            List<int> removeNumbers = new List<int> {25, 20, 40, 30, 10 };
           

             RemoveEqualNumbers(removeNumbers, numbers);
        }

        static void RemoveEqualNumbers(List<int> removeNumbers, List<int> numbers)
        {
            int counter = 1;
            for (int i = 0; i < removeNumbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (removeNumbers[i] == numbers[j])
                    {
                        numbers.RemoveAt(j);
                        counter = 0;
                    }
                }
                
            }
            if (counter == 1)
            {
                PrintNumbers(removeNumbers, numbers);
                return;
            }
            RemoveEqualNumbers(removeNumbers, numbers);
        }

        static void PrintNumbers(List<int> removeNumbers, List<int> numbers)
        {
            numbers.AddRange(removeNumbers);
            numbers.Sort();

            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
